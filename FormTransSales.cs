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
    public partial class FormTransSales : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da, daDetail;
        DataSet ds, dsDetail;
        string empID;

        public FormTransSales(MySqlConnection pConn, string emp)
        {
            InitializeComponent();
            conn = pConn;
            empID = emp;
        }

        private void FormTransSales_Load(object sender, EventArgs e)
        {
            getSalesID();
        }

        private void getSalesID()
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "fGenSalesID";

                cmd.Parameters.Add("hslID", MySqlDbType.VarChar);
                cmd.Parameters["hslID"].Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteScalar();
                txtSalesID.Text = cmd.Parameters["hslID"].Value.ToString();
                conn.Close();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCreateSales_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT sales_status FROM SALES WHERE sales_id = @id";
                cmd.Parameters.AddWithValue("@id", txtSalesID.Text);
                conn.Open();
                var result = cmd.ExecuteScalar();
                
                string salesStatus = "";
                if (result != null) { salesStatus = cmd.ExecuteScalar().ToString(); }
                else { salesStatus = "none"; }
                conn.Close();

                if (salesStatus == "COMPLETED")
                {
                    MessageBox.Show("Sales is already COMPLETED !");
                } else if (salesStatus == "PENDING")
                {
                    MessageBox.Show("Sales is PENDING ! You can continue!");
                    activateCart();
                } else if (salesStatus == "none")
                {
                    MessageBox.Show("Sales ID is INVALID !");
                    getSalesID();

                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO SALES (SALES_ID, EMPLOYEE_ID) VALUES " +
                        "(@sid,@eid)";
                    cmd.Parameters.AddWithValue("@sid", txtSalesID.Text);
                    cmd.Parameters.AddWithValue("@eid", empID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    activateCart();
                }
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void activateCart()
        {
            getCategory();
            txtSalesID.Enabled = false;
            btnCreateSales.Enabled = false;
            gbDetail.Visible = true;
            showDetail();
        }

        private void deactivateCart()
        {
            txtSalesID.Enabled = true;
            btnCreateSales.Enabled = true;
            gbDetail.Visible = false;
            dsDetail.Clear();
        }

        private void getCategory()
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT distinct product_category FROM product";

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                cbCategory.Items.Clear();
                cbCategory.Items.Add("--ALL--");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbCategory.Items.Add(reader.GetString(0));
                    }
                    cbCategory.SelectedIndex = 0;
                }
                else MessageBox.Show("No rows found.");
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lihatDataProduct(string parCat)
        {
            try
            {
                ds = new DataSet();
                string cmdText = "SELECT product_id, product_name, product_stock FROM product WHERE product_is_available = 1";
                if (parCat != "--ALL--")
                    cmdText = "SELECT product_id, product_name, product_stock FROM product WHERE product_is_available = 1 AND lower(product_category)='" + parCat.ToLower() + "'";

                conn.Close();
                conn.Open();
                da = new MySqlDataAdapter(cmdText, conn);
                da.Fill(ds);
                cbProduct.DataSource = ds.Tables[0];
                cbProduct.DisplayMember = "product_name";
                cbProduct.ValueMember = "product_id";
                cbStock.DataSource = ds.Tables[0];
                cbStock.DisplayMember = "product_stock";
                cbStock.ValueMember = "product_stock";
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lihatDataProduct(cbCategory.SelectedItem.ToString());
        }

        private void cbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idx = cbProduct.SelectedIndex;
            cbStock.SelectedIndex = idx;
            nupQty.Maximum = Convert.ToInt32(cbStock.SelectedValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE SALES SET sales_payment_method = @meth WHERE sales_id = @id";
                cmd.Parameters.AddWithValue("@meth", cbPaymentMethod.Text);
                cmd.Parameters.AddWithValue("@id", txtSalesID.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Sales Completed! ");
                deactivateCart();
                FormTransSales_Load(sender, e);
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtSalesID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnCreateSales_Click(sender, e);
        }

        private void showDetail()
        {
            try
            {
                dsDetail = new DataSet();
                string cmdText = "SELECT sd.sales_id, sd.product_id, p.product_name, sd.sales_qty " +
                                 "FROM sales_detail sd " +
                                 "JOIN product p ON sd.product_id = p.product_id " +
                                 "WHERE sd.sales_id = '" + txtSalesID.Text + "'";

                conn.Close();
                conn.Open();
                daDetail = new MySqlDataAdapter(cmdText, conn);
                daDetail.Fill(dsDetail);
                dgvDetail.DataSource = dsDetail.Tables[0];
                dgvDetail.Refresh();
                conn.Close();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnATC_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO SALES_DETAIL (SALES_ID, PRODUCT_ID, SALES_QTY) VALUES " +
                    "(@sid,@pid,@qty)";
                cmd.Parameters.AddWithValue("@sid", txtSalesID.Text);
                cmd.Parameters.AddWithValue("@pid", cbProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", nupQty.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                showDetail();

            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
