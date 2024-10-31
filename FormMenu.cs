using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APP_DB_RetailShop
{
    public partial class FormMenu : Form
    {
        MySqlConnection conn;
        string empID;

        public FormMenu(MySqlConnection pConn, string pEmpId)
        {
            InitializeComponent();
            conn = pConn;
            empID = pEmpId;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblEmpID.Text = "Welcome, " + empID;
        }

        private void btnMasterProduct_Click(object sender, EventArgs e)
        {
            FormMasterProduct fMasterProduct = new FormMasterProduct(conn, empID);
            fMasterProduct.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void btnMasterEmployee_Click(object sender, EventArgs e)
        {
            FormMasterEmployee fMasterEmployee = new FormMasterEmployee(conn);
            fMasterEmployee.ShowDialog();
        }

        private void btnInputSales_Click(object sender, EventArgs e)
        {
            FormTransSales fTransSales = new FormTransSales(conn,empID);
            fTransSales.ShowDialog();
        }

        private void btnRepSalesComplete_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(conn, "sales complete");
            fReport.ShowDialog();
        }

        private void btnRepEmpPerformance_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(conn, "employee performance");
            fReport.ShowDialog();
        }

        private void btnRepProdPerformance_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(conn, "product performance");
            fReport.ShowDialog();
        }

        private void btnRepAllSales_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(conn, "all sales");
            fReport.ShowDialog();
        }

        private void btnRepPriceHistory_Click(object sender, EventArgs e)
        {
            FormReport fReport = new FormReport(conn, "price");
            fReport.ShowDialog();
        }
    }
}
