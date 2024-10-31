
namespace APP_DB_RetailShop
{
    partial class FormReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblJudul = new System.Windows.Forms.Label();
            this.gbFilterDate = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbFilterProd = new System.Windows.Forms.GroupBox();
            this.cbProd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbFilterDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.gbFilterProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(18, 57);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(668, 434);
            this.dgvReport.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(13, 13);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(70, 25);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "label1";
            // 
            // gbFilterDate
            // 
            this.gbFilterDate.Controls.Add(this.btnShow);
            this.gbFilterDate.Controls.Add(this.dtpEnd);
            this.gbFilterDate.Controls.Add(this.label2);
            this.gbFilterDate.Controls.Add(this.dtpStart);
            this.gbFilterDate.Controls.Add(this.label1);
            this.gbFilterDate.Location = new System.Drawing.Point(692, 56);
            this.gbFilterDate.Name = "gbFilterDate";
            this.gbFilterDate.Size = new System.Drawing.Size(377, 149);
            this.gbFilterDate.TabIndex = 2;
            this.gbFilterDate.TabStop = false;
            this.gbFilterDate.Text = "Filter Sales by Date";
            this.gbFilterDate.Visible = false;
            this.gbFilterDate.VisibleChanged += new System.EventHandler(this.gbFilterDate_VisibleChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(70, 107);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 25);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(70, 69);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(282, 22);
            this.dtpEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End :";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(70, 31);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(282, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start :";
            // 
            // chartReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(692, 212);
            this.chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(429, 279);
            this.chartReport.TabIndex = 3;
            this.chartReport.Text = "chart1";
            this.chartReport.Visible = false;
            // 
            // gbFilterProd
            // 
            this.gbFilterProd.Controls.Add(this.cbProd);
            this.gbFilterProd.Location = new System.Drawing.Point(692, 57);
            this.gbFilterProd.Name = "gbFilterProd";
            this.gbFilterProd.Size = new System.Drawing.Size(377, 74);
            this.gbFilterProd.TabIndex = 4;
            this.gbFilterProd.TabStop = false;
            this.gbFilterProd.Text = "Filter by Product";
            this.gbFilterProd.Visible = false;
            // 
            // cbProd
            // 
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(21, 31);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(331, 24);
            this.cbProd.TabIndex = 0;
            this.cbProd.SelectedIndexChanged += new System.EventHandler(this.cbProd_SelectedIndexChanged);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 503);
            this.Controls.Add(this.gbFilterProd);
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.gbFilterDate);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.dgvReport);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbFilterDate.ResumeLayout(false);
            this.gbFilterDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.gbFilterProd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox gbFilterDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.GroupBox gbFilterProd;
        private System.Windows.Forms.ComboBox cbProd;
    }
}