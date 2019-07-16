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
    public partial class frmSalesDetail : Form
    {
        public frmSalesDetail()
        {
            InitializeComponent();
        }
        string conn = dbClass.getString();
        private void frmSalesDetail_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void DisplayData()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(conn);
                //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "select s.code as Item_Code,s.name as Item_Name, s.unitPrice as Unit_Price, si.PurchasedQuantity as Purchased_Quantity, si.ItemSum as Individual_Sum, si.BilledDate as Billed_Date from Stock s, SoldItems si where s.code = si.ItemCode";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                //viewing data
                dgvSoldItems.DataSource = dtbl;
                foreach (DataGridViewBand band in dgvSoldItems.Columns)
                {
                    band.ReadOnly = true;
                }
                string query1 = "Select * from BillOrder";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
                DataTable dtbl1 = new DataTable();
                sda1.Fill(dtbl1);

                //viewing data
                dgvBillOrder.DataSource = dtbl1;
                foreach (DataGridViewBand band in dgvBillOrder.Columns)
                {
                    band.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
