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
    public partial class FormMasterProduct : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        string mode = "insert";
        string empID;

        public FormMasterProduct(MySqlConnection pConn, string emp)
        {
            InitializeComponent();
            conn = pConn;
            empID = emp;
        }

        private void FormMasterProduct_Load(object sender, EventArgs e)
        {
            getCategory();
            lihatDataProduct("--ALL--");
            mode = "insert";
            lblMode.Text = "mode : " + mode;
        }

        private void lihatDataProduct(string parCat)
        {
            try
            {
                string cmdText = "SELECT product_id, product_name, product_stock, product_sell_price FROM product WHERE product_is_available = 1";
                if (parCat != "--ALL--") 
                    cmdText = "SELECT product_id, product_name, product_stock, product_sell_price FROM product WHERE product_is_available = 1 AND lower(product_category)='" + parCat.ToLower() + "'";

                conn.Close();
                conn.Open();

                ds = new DataSet();
                da = new MySqlDataAdapter(cmdText, conn);
                da.Fill(ds);
                dgvProduct.DataSource = ds.Tables[0];
                dgvProduct.Refresh();
                conn.Close();
            } catch (Exception ex) {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
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
                cbCat.Items.Clear();
                cbCategory.Items.Add("--ALL--");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbCategory.Items.Add(reader.GetString(0));
                        cbCat.Items.Add(reader.GetString(0));
                    }
                    cbCategory.SelectedIndex = 0;
                    cbCat.SelectedIndex = 0;
                }
                else MessageBox.Show("No rows found.");
                reader.Close();
                conn.Close();
            } catch (Exception ex) {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lihatDataProduct(cbCategory.SelectedItem.ToString());
        }

        private void txtProdName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (mode == "insert") { 
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    /*
                    cmd.CommandText = "SELECT fGenProductID(@cat, @name)";
                    cmd.Parameters.AddWithValue("@cat", cbCat.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@name", txtProdName.Text);
                    */

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "fGenProductID";

                    cmd.Parameters.Add("hslID", MySqlDbType.VarChar);
                    cmd.Parameters["hslID"].Direction = ParameterDirection.ReturnValue;

                    cmd.Parameters.AddWithValue("parCat", cbCat.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("parName", txtProdName.Text);

                    conn.Open();
                    cmd.ExecuteScalar();
                    txtProdID.Text = cmd.Parameters["hslID"].Value.ToString();
                    conn.Close();
                }
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void bersihkan()
        {
            cbCat.SelectedIndex = 0;
            cbCat.Enabled = true;
            txtProdID.Clear();
            txtProdName.Clear();
            txtSellPrice.Clear();
            nupStock.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bersihkan();
            FormMasterProduct_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                if (mode == "insert")
                    cmd.CommandText = "INSERT INTO PRODUCT (PRODUCT_ID, PRODUCT_NAME, PRODUCT_STOCK, PRODUCT_SELL_PRICE, PRODUCT_CATEGORY) VALUES " +
                        "(@id,@name,@stock,@price,@cat)";
                else if (mode == "update") { 
                    cmd.CommandText = "UPDATE PRODUCT SET PRODUCT_NAME = @name, PRODUCT_STOCK = @stock, PRODUCT_SELL_PRICE = @price " +
                        "WHERE PRODUCT_ID=@id";
                }
                cmd.Parameters.AddWithValue("@id",txtProdID.Text);
                cmd.Parameters.AddWithValue("@name",txtProdName.Text);
                cmd.Parameters.AddWithValue("@stock",nupStock.Value);
                cmd.Parameters.AddWithValue("@price",txtSellPrice.Text);
                cmd.Parameters.AddWithValue("@cat",cbCat.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (mode == "update")
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "pUpdEmpID";
                    cmd2.Parameters.AddWithValue("parEmpID", empID);
                    conn.Open();
                    cmd2.ExecuteScalar();
                    conn.Close();
                }

                MessageBox.Show("1 Data Saved !");
                bersihkan();
                FormMasterProduct_Load(sender, e);
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mode = "update";
                lblMode.Text = "mode : " + mode;
                btnDelete.Enabled = true;
                cbCat.Enabled = false;
                txtProdID.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_ID"].Value.ToString();
                txtProdName.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_NAME"].Value.ToString();
                nupStock.Value = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_STOCK"].Value.ToString());
                txtSellPrice.Text = dgvProduct.Rows[e.RowIndex].Cells["PRODUCT_SELL_PRICE"].Value.ToString();
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (mode == "update") {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE PRODUCT SET PRODUCT_IS_AVAILABLE = 0 " +
                        "WHERE PRODUCT_ID=@id";
                    cmd.Parameters.AddWithValue("@id", txtProdID.Text);
                  
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("1 Data Deleted !");
                    bersihkan();
                    FormMasterProduct_Load(sender, e);
                }
            } catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
