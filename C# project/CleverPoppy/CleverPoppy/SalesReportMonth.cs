using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverPoppy
{
    public partial class SalesReportMonth : Form
    {
        public string SD;
        public string ED;
        public SalesReportMonth(string start, string end)
        {
            this.SD = start;
            this.ED = end;
            InitializeComponent();
        }
        string conn = dbClass.getString();
        
        private void SalesReportMonth_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            sqlcon.Open();
            string query = @"select * from BillOrder where 
              BillDate >= '"+SD+"' and BillDate <= '"+ED+"'";
            
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds, "BillOrder");
            SalesReport cr1 = new SalesReport();
            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
            

        }
    }
}
