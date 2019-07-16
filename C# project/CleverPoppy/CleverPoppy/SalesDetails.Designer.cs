namespace CleverPoppy
{
    partial class frmSalesDetail
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
            this.dgvBillOrder = new System.Windows.Forms.DataGridView();
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBillOrder
            // 
            this.dgvBillOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillOrder.Location = new System.Drawing.Point(235, 42);
            this.dgvBillOrder.Name = "dgvBillOrder";
            this.dgvBillOrder.Size = new System.Drawing.Size(516, 150);
            this.dgvBillOrder.TabIndex = 0;
            // 
            // dgvSoldItems
            // 
            this.dgvSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldItems.Location = new System.Drawing.Point(71, 284);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.Size = new System.Drawing.Size(883, 201);
            this.dgvSoldItems.TabIndex = 1;
            // 
            // frmSalesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 534);
            this.Controls.Add(this.dgvSoldItems);
            this.Controls.Add(this.dgvBillOrder);
            this.Name = "frmSalesDetail";
            this.Text = "SalesDetails";
            this.Load += new System.EventHandler(this.frmSalesDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillOrder;
        private System.Windows.Forms.DataGridView dgvSoldItems;
    }
}