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
    public partial class SalesProducts : Form
    {
        public string SD;
        public string ED;
        public SalesProducts(string start, string end)
        {
            this.SD = start;
            this.ED = end;
            InitializeComponent();
        }
        string conn = dbClass.getString();

        private void SalesProducts_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            sqlcon.Open();
            string query = @"select * from SoldItems where 
              BilledDate >= '" + SD + "' and BilledDate <= '" + ED + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds, "SoldItems");
            SalesForItems cr1 = new SalesForItems();
            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
        }
    }
}
