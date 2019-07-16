using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverPoppy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            //this.Hide();
            (new PrintBill()).Show();
            

        }

        private void btnCheck_MouseHover(object sender, EventArgs e)
        {
            panel4.Height = btnCheck.Height;
            panel4.Top = btnCheck.Top;
        }

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            panel4.Height = btnStock.Height;
            panel4.Top = btnStock.Top;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrintBill_MouseHover(object sender, EventArgs e)
        {
            panel4.Height = btnPrintBill.Height;
            panel4.Top = btnPrintBill.Top;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new UpdateStock()).Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new CheckAvailability()).Show();
        }

        private void btn_closeform_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
       
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if( this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState== FormWindowState.Normal){
                this.WindowState = FormWindowState.Maximized;
            }
          

            
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private int imageNo = 1;

        private void loadNextImage()
        {
            if (imageNo == 7)
            {
                imageNo = 1;
            }
            picbox_slide.ImageLocation = string.Format(@"Images1\{0}.jpg", imageNo);
            imageNo++;
        }

        private void timer_picbox_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            string start = startDate.Value.ToString();
            string end = endDate.Value.ToString();

            
            (new SalesReportMonth(start,end)).Show();

        }

        private void btnProductSales_Click(object sender, EventArgs e)
        {
            string start = startDate.Value.ToString();
            string end = endDate.Value.ToString();


            (new SalesProducts(start, end)).Show();
        }
    }
}
