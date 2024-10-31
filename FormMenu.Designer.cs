
namespace APP_DB_RetailShop
{
    partial class FormMenu
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
            this.btnMasterProduct = new System.Windows.Forms.Button();
            this.btnMasterEmployee = new System.Windows.Forms.Button();
            this.btnInputSales = new System.Windows.Forms.Button();
            this.btnRepSalesComplete = new System.Windows.Forms.Button();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRepEmpPerformance = new System.Windows.Forms.Button();
            this.btnRepProdPerformance = new System.Windows.Forms.Button();
            this.btnRepAllSales = new System.Windows.Forms.Button();
            this.btnRepPriceHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasterProduct
            // 
            this.btnMasterProduct.Location = new System.Drawing.Point(16, 65);
            this.btnMasterProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasterProduct.Name = "btnMasterProduct";
            this.btnMasterProduct.Size = new System.Drawing.Size(147, 65);
            this.btnMasterProduct.TabIndex = 0;
            this.btnMasterProduct.Text = "Master Data PRODUCT";
            this.btnMasterProduct.UseVisualStyleBackColor = true;
            this.btnMasterProduct.Click += new System.EventHandler(this.btnMasterProduct_Click);
            // 
            // btnMasterEmployee
            // 
            this.btnMasterEmployee.Location = new System.Drawing.Point(189, 65);
            this.btnMasterEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasterEmployee.Name = "btnMasterEmployee";
            this.btnMasterEmployee.Size = new System.Drawing.Size(147, 65);
            this.btnMasterEmployee.TabIndex = 1;
            this.btnMasterEmployee.Text = "Master Data EMPLOYEE";
            this.btnMasterEmployee.UseVisualStyleBackColor = true;
            this.btnMasterEmployee.Click += new System.EventHandler(this.btnMasterEmployee_Click);
            // 
            // btnInputSales
            // 
            this.btnInputSales.Location = new System.Drawing.Point(359, 65);
            this.btnInputSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputSales.Name = "btnInputSales";
            this.btnInputSales.Size = new System.Drawing.Size(147, 65);
            this.btnInputSales.TabIndex = 2;
            this.btnInputSales.Text = "Input SALES Transaction";
            this.btnInputSales.UseVisualStyleBackColor = true;
            this.btnInputSales.Click += new System.EventHandler(this.btnInputSales_Click);
            // 
            // btnRepSalesComplete
            // 
            this.btnRepSalesComplete.Location = new System.Drawing.Point(18, 149);
            this.btnRepSalesComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepSalesComplete.Name = "btnRepSalesComplete";
            this.btnRepSalesComplete.Size = new System.Drawing.Size(147, 65);
            this.btnRepSalesComplete.TabIndex = 3;
            this.btnRepSalesComplete.Text = "COMPLETED Sales Report";
            this.btnRepSalesComplete.UseVisualStyleBackColor = true;
            this.btnRepSalesComplete.Click += new System.EventHandler(this.btnRepSalesComplete_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(15, 25);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmpID.Size = new System.Drawing.Size(83, 17);
            this.lblEmpID.TabIndex = 6;
            this.lblEmpID.Text = "EmployeeID";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(431, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 36);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRepEmpPerformance
            // 
            this.btnRepEmpPerformance.Location = new System.Drawing.Point(189, 149);
            this.btnRepEmpPerformance.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepEmpPerformance.Name = "btnRepEmpPerformance";
            this.btnRepEmpPerformance.Size = new System.Drawing.Size(147, 65);
            this.btnRepEmpPerformance.TabIndex = 8;
            this.btnRepEmpPerformance.Text = "EMPLOYEE PERFORMANCE Report";
            this.btnRepEmpPerformance.UseVisualStyleBackColor = true;
            this.btnRepEmpPerformance.Click += new System.EventHandler(this.btnRepEmpPerformance_Click);
            // 
            // btnRepProdPerformance
            // 
            this.btnRepProdPerformance.Location = new System.Drawing.Point(359, 149);
            this.btnRepProdPerformance.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepProdPerformance.Name = "btnRepProdPerformance";
            this.btnRepProdPerformance.Size = new System.Drawing.Size(147, 65);
            this.btnRepProdPerformance.TabIndex = 9;
            this.btnRepProdPerformance.Text = "PRODUCT PERFORMANCE Report";
            this.btnRepProdPerformance.UseVisualStyleBackColor = true;
            this.btnRepProdPerformance.Click += new System.EventHandler(this.btnRepProdPerformance_Click);
            // 
            // btnRepAllSales
            // 
            this.btnRepAllSales.Location = new System.Drawing.Point(18, 235);
            this.btnRepAllSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepAllSales.Name = "btnRepAllSales";
            this.btnRepAllSales.Size = new System.Drawing.Size(147, 65);
            this.btnRepAllSales.TabIndex = 10;
            this.btnRepAllSales.Text = "ALL Sales Report";
            this.btnRepAllSales.UseVisualStyleBackColor = true;
            this.btnRepAllSales.Click += new System.EventHandler(this.btnRepAllSales_Click);
            // 
            // btnRepPriceHistory
            // 
            this.btnRepPriceHistory.Location = new System.Drawing.Point(189, 235);
            this.btnRepPriceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepPriceHistory.Name = "btnRepPriceHistory";
            this.btnRepPriceHistory.Size = new System.Drawing.Size(147, 65);
            this.btnRepPriceHistory.TabIndex = 11;
            this.btnRepPriceHistory.Text = "PRICE CHANGED HISTORY Report";
            this.btnRepPriceHistory.UseVisualStyleBackColor = true;
            this.btnRepPriceHistory.Click += new System.EventHandler(this.btnRepPriceHistory_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 322);
            this.Controls.Add(this.btnRepPriceHistory);
            this.Controls.Add(this.btnRepAllSales);
            this.Controls.Add(this.btnRepProdPerformance);
            this.Controls.Add(this.btnRepEmpPerformance);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnRepSalesComplete);
            this.Controls.Add(this.btnInputSales);
            this.Controls.Add(this.btnMasterEmployee);
            this.Controls.Add(this.btnMasterProduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasterProduct;
        private System.Windows.Forms.Button btnMasterEmployee;
        private System.Windows.Forms.Button btnInputSales;
        private System.Windows.Forms.Button btnRepSalesComplete;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRepEmpPerformance;
        private System.Windows.Forms.Button btnRepProdPerformance;
        private System.Windows.Forms.Button btnRepAllSales;
        private System.Windows.Forms.Button btnRepPriceHistory;
    }
}