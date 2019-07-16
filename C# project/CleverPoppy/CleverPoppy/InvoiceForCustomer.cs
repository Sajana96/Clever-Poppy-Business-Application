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
    public partial class InvoiceForCustomer : Form
    {
        public InvoiceForCustomer()
        {
            InitializeComponent();
        }
        string conn = dbClass.getString();
        private void InvoiceForCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(conn);
                sqlcon.Open();
                string query = "select code , name  , price , quantity , cost  from Bill";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Bill");
                Invoice cr1 = new Invoice();
                cr1.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr1;
                crystalReportViewer1.Refresh();
            }
            catch (SystemException ex)
            {

                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
