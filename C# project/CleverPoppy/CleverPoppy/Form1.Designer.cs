namespace CleverPoppy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picbox_slide = new System.Windows.Forms.PictureBox();
            this.btn_closeform = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.timer_picbox = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_slide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintBill.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintBill.Location = new System.Drawing.Point(0, 402);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(236, 97);
            this.btnPrintBill.TabIndex = 4;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            this.btnPrintBill.MouseHover += new System.EventHandler(this.btnPrintBill_MouseHover);
            // 
            // btnStock
            // 
            this.btnStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStock.Location = new System.Drawing.Point(0, 265);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(236, 97);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Update Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseHover += new System.EventHandler(this.btnStock_MouseHover);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCheck.Location = new System.Drawing.Point(0, 122);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(236, 96);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseHover += new System.EventHandler(this.btnCheck_MouseHover);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(234, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 96);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // picbox_slide
            // 
            this.picbox_slide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox_slide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_slide.BackgroundImage")));
            this.picbox_slide.Image = ((System.Drawing.Image)(resources.GetObject("picbox_slide.Image")));
            this.picbox_slide.Location = new System.Drawing.Point(240, 120);
            this.picbox_slide.Name = "picbox_slide";
            this.picbox_slide.Size = new System.Drawing.Size(614, 377);
            this.picbox_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_slide.TabIndex = 5;
            this.picbox_slide.TabStop = false;
            // 
            // btn_closeform
            // 
            this.btn_closeform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeform.BackColor = System.Drawing.Color.White;
            this.btn_closeform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_closeform.BackgroundImage")));
            this.btn_closeform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_closeform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeform.FlatAppearance.BorderSize = 0;
            this.btn_closeform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeform.Location = new System.Drawing.Point(819, 9);
            this.btn_closeform.Name = "btn_closeform";
            this.btn_closeform.Size = new System.Drawing.Size(28, 24);
            this.btn_closeform.TabIndex = 6;
            this.btn_closeform.UseVisualStyleBackColor = false;
            this.btn_closeform.Click += new System.EventHandler(this.btn_closeform_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.White;
            this.btn_maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.BackgroundImage")));
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Location = new System.Drawing.Point(780, 9);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(28, 24);
            this.btn_maximize.TabIndex = 7;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.White;
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(742, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(28, 24);
            this.btn_minimize.TabIndex = 8;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("picbox_logo.Image")));
            this.picbox_logo.Location = new System.Drawing.Point(39, 12);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(165, 89);
            this.picbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_logo.TabIndex = 9;
            this.picbox_logo.TabStop = false;
            // 
            // timer_picbox
            // 
            this.timer_picbox.Enabled = true;
            this.timer_picbox.Interval = 2000;
            this.timer_picbox.Tick += new System.EventHandler(this.timer_picbox_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.picbox_logo);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnPrintBill);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 564);
            this.panel1.TabIndex = 10;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalesReport.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSalesReport.Location = new System.Drawing.Point(547, 60);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(184, 46);
            this.btnSalesReport.TabIndex = 11;
            this.btnSalesReport.Text = "View Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(341, 12);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 27);
            this.startDate.TabIndex = 12;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(341, 68);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 27);
            this.endDate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(281, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(281, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "End";
            // 
            // btnProductSales
            // 
            this.btnProductSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductSales.BackColor = System.Drawing.Color.Transparent;
            this.btnProductSales.FlatAppearance.BorderSize = 0;
            this.btnProductSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSales.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnProductSales.Location = new System.Drawing.Point(547, 12);
            this.btnProductSales.Name = "btnProductSales";
            this.btnProductSales.Size = new System.Drawing.Size(148, 39);
            this.btnProductSales.TabIndex = 16;
            this.btnProductSales.Text = "Product Sales";
            this.btnProductSales.UseVisualStyleBackColor = false;
            this.btnProductSales.Click += new System.EventHandler(this.btnProductSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 561);
            this.Controls.Add(this.btnProductSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.btn_closeform);
            this.Controls.Add(this.picbox_slide);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_slide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picbox_slide;
        private System.Windows.Forms.Button btn_closeform;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Timer timer_picbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductSales;
    }
}

