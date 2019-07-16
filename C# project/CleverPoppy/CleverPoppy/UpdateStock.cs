using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CleverPoppy
{
    public partial class UpdateStock : Form
    {

        public UpdateStock()
        {
            InitializeComponent();
        }
        string conn = dbClass.getString();
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        private void btnViewStock_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Stock";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            //viewing data
            dgvViewStock.DataSource = dtbl;
            foreach(DataGridViewBand band in dgvViewStock.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AddNewItem()).Show();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new UpdateItem()).Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
           
            (new frmSalesDetail()).Show();
        }
    }
}
