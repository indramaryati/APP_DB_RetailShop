
namespace APP_DB_RetailShop
{
    partial class FormMasterProduct
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(16, 41);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(640, 396);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by Category :";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(149, 7);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(296, 24);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sell Price :";
            // 
            // txtProdID
            // 
            this.txtProdID.Enabled = false;
            this.txtProdID.Location = new System.Drawing.Point(777, 76);
            this.txtProdID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdID.MaxLength = 7;
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(269, 22);
            this.txtProdID.TabIndex = 7;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(777, 160);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdName.MaxLength = 100;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(269, 22);
            this.txtProdName.TabIndex = 9;
            this.txtProdName.Leave += new System.EventHandler(this.txtProdName_Leave);
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(777, 204);
            this.nupStock.Margin = new System.Windows.Forms.Padding(4);
            this.nupStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(117, 22);
            this.nupStock.TabIndex = 10;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(777, 248);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(269, 22);
            this.txtSellPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category :";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(777, 119);
            this.cbCat.Margin = new System.Windows.Forms.Padding(4);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(269, 24);
            this.cbCat.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(777, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(885, 293);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(684, 41);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(90, 17);
            this.lblMode.TabIndex = 14;
            this.lblMode.Text = "mode : insert";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(827, 329);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 28);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormMasterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 459);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.nupStock);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMasterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMasterProduct";
            this.Load += new System.EventHandler(this.FormMasterProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.NumericUpDown nupStock;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnDelete;
    }
}