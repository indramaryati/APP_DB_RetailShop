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
    public partial class FormReport : Form
    {
        MySqlConnection conn;
        string repType;
        MySqlDataAdapter da;
        DataSet ds;
        string cmdText = "";

        public FormReport(MySqlConnection pConn, string tipe)
        {
            InitializeComponent();
            conn = pConn;
            repType = tipe;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                da = new MySqlDataAdapter();

                if (repType == "sales complete")
                {
                    chartReport.Visible = false;
                    gbFilterDate.Visible = false;
                    gbFilterProd.Visible = false;
                    lblJudul.Text = "COMPLETED SALES REPORT";
                    cmdText = "select * from vDaftarTransaksiSukses order by sales_date desc";
                } else if (repType == "employee performance")
                {
                    chartReport.Visible = false;
                    gbFilterDate.Visible = false;
                    gbFilterProd.Visible = false;
                    lblJudul.Text = "EMPLOYEE PERFORMANCE REPORT";
                    cmdText = "select * from vPerformaEmployee order by sales_sum desc";
                    lihatChart();
                } else if (repType == "product performance")
                {
                    chartReport.Visible = false;
                    gbFilterDate.Visible = false;
                    gbFilterProd.Visible = false;
                    lblJudul.Text = "PRODUCT PERFORMANCE REPORT";
                    cmdText = "select * from vPerformaProduct order by product_sales_sum desc";
                    lihatChart();
                } else if (repType == "all sales")
                {
                    chartReport.Visible = false;
                    gbFilterDate.Visible = true;
                    gbFilterProd.Visible = false;
                    lblJudul.Text = "ALL SALES REPORT";
                    cmdText = "select * from vPenjualan order by sales_date desc";
                }
                else if (repType == "price")
                {
                    chartReport.Visible = false;
                    gbFilterDate.Visible = false;
                    gbFilterProd.Visible = true;
                    getProduct();
                    lblJudul.Text = "PRODUCT CHANGED REPORT";
                    cmdText = "call pViewPriceHistory('ALL')";
                }
                else
                {
                    chartReport.Visible = false;
                    gbFilterDate.Visible = false;
                    gbFilterProd.Visible = false;
                    MessageBox.Show("No Report Selected ! Only show product table.");
                    cmdText = "select * from vAvailProduct";
                }

                conn.Close();
                conn.Open();

                ds = new DataSet();
                da = new MySqlDataAdapter(cmdText, conn);
                da.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                dgvReport.Refresh();
                conn.Close();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gbFilterDate_VisibleChanged(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Now.AddDays(-7);
            dtpEnd.Value = DateTime.Today;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = "COMPLETED SALES REPORT";
                cmdText = "select * from vPenjualan where sales_date >= '" + dtpStart.Value.ToString("yyyy-MM-dd") + 
                    "' and sales_date <= '" + dtpEnd.Value.ToString("yyyy-MM-dd") + "' order by sales_date desc";

                conn.Close();
                conn.Open();

                ds = new DataSet();
                da = new MySqlDataAdapter(cmdText, conn);
                da.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                dgvReport.Refresh();
                conn.Close();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lihatChart()
        {
            DataSet dsGraf = new DataSet();
            MySqlDataAdapter daGraf;
            chartReport.Visible = true;

            if (repType == "employee performance")
            {
                daGraf = new MySqlDataAdapter("SELECT employee_name, (sales_sum/1000) as sales_sum FROM vperformaemployee ORDER BY sales_sum desc LIMIT 10;", conn);
                daGraf.Fill(dsGraf);
                chartReport.DataSource = dsGraf;
                chartReport.Series["Sales"].XValueMember = "employee_name";
                chartReport.Series["Sales"].YValueMembers = "sales_sum";
                chartReport.Titles.Add("Total Sales by Employee");
            }
            else if (repType == "product performance")
            {
                daGraf = new MySqlDataAdapter("SELECT product_name, product_sales_sum FROM vperformaproduct ORDER BY product_sales_sum desc LIMIT 10;", conn);
                daGraf.Fill(dsGraf);
                chartReport.DataSource = dsGraf;
                chartReport.Series["Sales"].XValueMember = "product_name";
                chartReport.Series["Sales"].YValueMembers = "product_sales_sum";
                chartReport.Titles.Add("Total Sales per Product");
            }
        }

        private void getProduct()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT concat(product_id, ' | ', product_name) as prd FROM vAvailProduct ORDER BY product_id";

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                cbProd.Items.Clear();
                cbProd.Items.Add("ALL");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbProd.Items.Add(reader.GetString(0));
                    }
                    cbProd.SelectedIndex = 0;
                }
                else MessageBox.Show("No rows found.");
                reader.Close();
                conn.Close();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblJudul.Text = "COMPLETED SALES REPORT";
                if (cbProd.SelectedIndex == 0)
                    cmdText = "call pViewPriceHistory('ALL')";
                else
                    cmdText = "call pViewPriceHistory('" + cbProd.SelectedItem.ToString().Substring(0,7) + "')";

                conn.Close();
                conn.Open();

                ds = new DataSet();
                da = new MySqlDataAdapter(cmdText, conn);
                da.Fill(ds);
                dgvReport.DataSource = ds.Tables[0];
                dgvReport.Refresh();
                conn.Close();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
