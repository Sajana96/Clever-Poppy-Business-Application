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
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        string ProductName;
        string ProductCode;
        int price, currentQty, purchaseQty, updatedQty, cost;
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        
        string conn = dbClass.getString();
        private void PrintBill_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void ClearData()
        {
            txtCode.Clear();
            txtName.Clear();
            lblname.Text = "";
            lblprice.Text = "";
            txtPurchaseQty.Clear();
            price = 0;
            currentQty = 0;
            purchaseQty = 0;
            updatedQty = 0;
            cost = 0;
            ProductName = "";
            ProductName = "";

        }

        private void btn_closeform_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string q = "Delete from Bill";
            SqlDataAdapter sdaA = new SqlDataAdapter(q, sqlcon);
            DataTable dtblA = new DataTable();
            sdaA.Fill(dtblA);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();

            string qry1 = "Select quantity from Bill where code ='" + txtCode.Text + "' or name='" + txtName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qry1, sqlcon);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            reader1.Read();
            int pq = Convert.ToInt32(reader1["quantity"]);
            reader1.Close();

            string qry2 = "Update Stock set quantitiy =quantitiy+'" + pq + "' where code='" + txtCode.Text + "' or name='" + txtName.Text + "'";
            SqlDataAdapter sd1 = new SqlDataAdapter(qry2, sqlcon);
            DataTable dtblB = new DataTable();
            sd1.Fill(dtblB);




            string query = "Delete  from Bill where code ='"+txtCode.Text+"' or name='"+txtName.Text+"'";
            SqlDataAdapter sdaA = new SqlDataAdapter(query, sqlcon);
            DataTable dtblA = new DataTable();
            sdaA.Fill(dtblA);

            string qry = "Select SUM(cost) as total from Bill";
            SqlCommand cmd = new SqlCommand(qry, sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtTotal.Text = reader["total"].ToString();
            reader.Close();

            string qryCount = "Select COUNT(*) as Number from Bill";
            SqlCommand cmdCount = new SqlCommand(qryCount, sqlcon);
            SqlDataReader readerCount = cmdCount.ExecuteReader();
            readerCount.Read();
            txtNumOfItems.Text = readerCount["Number"].ToString();







            ClearData();
            DisplayData();


}

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dgvRefreshStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvRefreshStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvRefreshStock.CurrentRow.Selected = true;
                txtCode.Text = dgvRefreshStock.Rows[e.RowIndex].Cells["code"].FormattedValue.ToString();
            }
        }

        private void dgvRefreshStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            int NumOfItems = Convert.ToInt32(txtNumOfItems.Text);
            int totalPayment = Convert.ToInt32(txtTotal.Text);
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd");

            SqlConnection sqlcon = new SqlConnection(conn);
            string query = "Insert into BillOrder (BillDate, NumberOfItems, TotalPayment) values ('"+sqlFormattedDate+"', '"+NumOfItems+"', '"+totalPayment+"')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

           


            string query1 = "Insert into SoldItems ( ItemCode, PurchasedQuantity, ItemSum, BilledDate )  Select code, quantity, cost, billedDate from Bill  ";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);

            MessageBox.Show("Billed Successfully");
            (new InvoiceForCustomer()).Show();



        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            purchaseQty = Convert.ToInt32(txtPurchaseQty.Text);
            cost = purchaseQty * price;
            
            if (purchaseQty <= currentQty)
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd");
                updatedQty = currentQty - purchaseQty;
                SqlConnection sqlcon = new SqlConnection(conn);
                //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                sqlcon.Open();
                string query = "insert into Bill values('" + ProductCode + "','" + ProductName + "','" + purchaseQty + "','" + price + "','" + cost + "','"+sqlFormattedDate+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                string qry1 = "Update Stock set quantitiy ='"+updatedQty+"' where code='"+ProductCode+"' or name='"+ProductName+"'";
                SqlDataAdapter sd1 = new SqlDataAdapter(qry1, sqlcon);
                DataTable dtblB = new DataTable();
                sd1.Fill(dtblB);

                string qry = "Select SUM(cost) as total from Bill";
                SqlCommand cmd = new SqlCommand(qry, sqlcon);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtTotal.Text = reader["total"].ToString();
                reader.Close();

                string qryCount = "Select COUNT(*) as Number from Bill";
                SqlCommand cmdCount = new SqlCommand(qryCount, sqlcon);
                SqlDataReader readerCount = cmdCount.ExecuteReader();
                readerCount.Read();
                txtNumOfItems.Text = readerCount["Number"].ToString();

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Existing units are not sufficient for the order");
                DisplayData();
                ClearData();
            }

        }

        public void DisplayData()
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Bill";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conn);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# projects\C# project\CleverPoppy\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            String query = "Select * from Stock where code='" + txtCode.Text + "' or name = '" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                ProductName = lblname.Text;
                lblname.Text = reader["name"].ToString();
                lblprice.Text = reader["unitPrice"].ToString();
                price = Convert.ToInt32(reader["unitPrice"]);

                currentQty= Convert.ToInt32(reader["quantitiy"]);
                if (currentQty == 0)
                {

                    MessageBox.Show("No units available");
                    lblname.Text = "";
                    lblprice.Text = "";
                    txtCode.Clear();
                    txtName.Clear();
                    currentQty = Convert.ToInt32(reader["quantitiy"]);
                    price = 0;
                    DisplayData();

                }
                else
                {
                    price = Convert.ToInt32(reader["unitPrice"]);
                    currentQty = Convert.ToInt32(reader["quantitiy"]);
                    ProductName = lblname.Text;
                    ProductCode = reader["code"].ToString();
                    DisplayData();
                }


            }
            else
            {
                MessageBox.Show("No item found");
                txtCode.Clear();
                txtName.Clear();
            }
        }
    }
}
