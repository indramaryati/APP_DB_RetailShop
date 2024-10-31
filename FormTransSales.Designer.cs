
namespace APP_DB_RetailShop
{
    partial class FormTransSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.btnCreateSales = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnATC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.nupQty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales ID :";
            // 
            // txtSalesID
            // 
            this.txtSalesID.Location = new System.Drawing.Point(96, 27);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(175, 22);
            this.txtSalesID.TabIndex = 1;
            this.txtSalesID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesID_KeyPress);
            // 
            // btnCreateSales
            // 
            this.btnCreateSales.Location = new System.Drawing.Point(277, 20);
            this.btnCreateSales.Name = "btnCreateSales";
            this.btnCreateSales.Size = new System.Drawing.Size(165, 37);
            this.btnCreateSales.TabIndex = 2;
            this.btnCreateSales.Text = "CREATE NEW SALES";
            this.btnCreateSales.UseVisualStyleBackColor = true;
            this.btnCreateSales.Click += new System.EventHandler(this.btnCreateSales_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Method :";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(17, 61);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(252, 24);
            this.cbCategory.TabIndex = 9;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.cbPaymentMethod);
            this.gbDetail.Controls.Add(this.btnATC);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.btnSave);
            this.gbDetail.Controls.Add(this.dgvDetail);
            this.gbDetail.Controls.Add(this.nupQty);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.cbStock);
            this.gbDetail.Controls.Add(this.cbProduct);
            this.gbDetail.Controls.Add(this.cbCategory);
            this.gbDetail.Location = new System.Drawing.Point(25, 103);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(1032, 376);
            this.gbDetail.TabIndex = 10;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Sales Detail";
            this.gbDetail.Visible = false;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "QRIS",
            "Debit",
            "Credit",
            "Transfer"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(843, 244);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(173, 24);
            this.cbPaymentMethod.TabIndex = 12;
            // 
            // btnATC
            // 
            this.btnATC.Location = new System.Drawing.Point(253, 96);
            this.btnATC.Name = "btnATC";
            this.btnATC.Size = new System.Drawing.Size(141, 26);
            this.btnATC.TabIndex = 17;
            this.btnATC.Text = "ADD TO CART";
            this.btnATC.UseVisualStyleBackColor = true;
            this.btnATC.Click += new System.EventHandler(this.btnATC_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(843, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 70);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(17, 129);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(681, 227);
            this.dgvDetail.TabIndex = 16;
            // 
            // nupQty
            // 
            this.nupQty.Location = new System.Drawing.Point(127, 100);
            this.nupQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQty.Name = "nupQty";
            this.nupQty.Size = new System.Drawing.Size(120, 22);
            this.nupQty.TabIndex = 15;
            this.nupQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Input Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Available Stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Product :";
            // 
            // cbStock
            // 
            this.cbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbStock.Enabled = false;
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(537, 61);
            this.cbStock.Margin = new System.Windows.Forms.Padding(4);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(80, 24);
            this.cbStock.TabIndex = 11;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(277, 61);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(252, 24);
            this.cbProduct.TabIndex = 10;
            this.cbProduct.SelectionChangeCommitted += new System.EventHandler(this.cbProduct_SelectionChangeCommitted);
            // 
            // FormTransSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 491);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.btnCreateSales);
            this.Controls.Add(this.txtSalesID);
            this.Controls.Add(this.label1);
            this.Name = "FormTransSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransSales";
            this.Load += new System.EventHandler(this.FormTransSales_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.Button btnCreateSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.NumericUpDown nupQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnATC;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
    }
}