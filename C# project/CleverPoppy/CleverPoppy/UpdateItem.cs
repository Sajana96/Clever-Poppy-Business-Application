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
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
        }
        string conn = dbClass.getString();
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        public void DisplayData()
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Stock";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            //viewing data
            dgvRefreshStock.DataSource = dtbl;
            foreach (DataGridViewBand band in dgvRefreshStock.Columns)
            {
                band.ReadOnly = true;
            }
        }

        public void ClearFields()
        {
            txtCode.Clear();
            lblCurrentQuantity.Text = "";
            lblCurrentPrice.Text = "";
            lblName.Text = "";
            txtNewPrice.Clear();
            txtNewQuantity.Clear();
            txtCode.Focus();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblOk.Text = "";
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            String query = "Select name,quantitiy,unitPrice from Stock where code='" + txtCode.Text + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                lblName.Text = reader["name"].ToString();
                lblCurrentPrice.Text = reader["unitPrice"].ToString();
                lblCurrentQuantity.Text = reader["quantitiy"].ToString();
                DisplayData();

            }
            else
            {
                lblError.Text="Item not found";
                ClearFields();
                DisplayData();
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblOk.Text = "";
            ClearFields();
            DisplayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblOk.Text = "";
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            if (txtNewPrice.Text == "" && !(txtNewQuantity.Text == ""))
            {
                String query = "Update Stock set quantitiy='"+txtNewQuantity.Text+"' where code='"+txtCode.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                lblOk.Text = "Successfull updated Quantity";
                ClearFields();
                DisplayData();
            }
            else if(txtNewQuantity.Text == "" && !(txtNewPrice.Text == ""))
            {
                String query = "Update Stock set unitPrice='" + txtNewPrice.Text + "' where code='" + txtCode.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                lblOk.Text = "Successfull updated Price";
                ClearFields();
                DisplayData();
            }
            else if(!(txtNewPrice.Text == "" && txtNewQuantity.Text == ""))
            {
                String query = "Update Stock set unitPrice='" + txtNewPrice.Text + "', quantitiy='"+txtNewQuantity.Text+"' where code='" + txtCode.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                lblOk.Text = "Successfull updated Quantity and Price";
                ClearFields();
                DisplayData();
            }
            else if(txtNewPrice.Text == "" && txtNewQuantity.Text == "")
            {
                lblError.Text = "No values to add";
                ClearFields();
                DisplayData();
            }
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new UpdateStock()).Show();
        }
    }
}
