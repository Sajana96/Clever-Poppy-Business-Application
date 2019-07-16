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
    public partial class CheckAvailability : Form
    {
        public CheckAvailability()
        {
            InitializeComponent();
        }
        string conn = dbClass.getString();
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        public void ClearData()
        {
            txtCode.Clear();
            txtName.Clear();
            lblCurrentQuantity.Text = "";
            lblCurrentPrice.Text = "";
            lblError.Text = "";
            lblname.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            String query = "Select name,quantitiy,unitPrice from Stock where code='" + txtCode.Text + "' or name = '"+txtName.Text+"'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {

                lblname.Text = reader["name"].ToString();
                lblCurrentPrice.Text = reader["unitPrice"].ToString();
                int d = Convert.ToInt32(reader["quantitiy"]);
                if(d == 0)
                {
                    lblCurrentQuantity.ForeColor = System.Drawing.Color.Firebrick;
                    lblCurrentQuantity.Text = "Not Available";

                }
                else
                {
                    lblCurrentQuantity.ForeColor = System.Drawing.Color.DarkBlue;
                    lblCurrentQuantity.Text = reader["quantitiy"].ToString();
                }
              

            }
            else
            {
                lblError.Text = "Item not found";
                txtCode.Clear();
                txtName.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
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
    }
}
