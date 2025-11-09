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
    public partial class FormMasterEmployee : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        string mode = "insert";

        public FormMasterEmployee(MySqlConnection pConn)
        {
            InitializeComponent();
            conn = pConn;
        }

        private void FormMasterEmployee_Load(object sender, EventArgs e)
        {
            lihatDataEmployee();
            mode = "insert";
            lblMode.Text = "mode : " + mode;
        }

        private void lihatDataEmployee()
        {
            try
            {
                string cmdText = "SELECT * FROM vAvailEmployee";

                conn.Close();
                conn.Open();

                ds = new DataSet();
                da = new MySqlDataAdapter(cmdText, conn);
                da.Fill(ds);
                dgvEmployee.DataSource = ds.Tables[0];
                dgvEmployee.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bersihkan()
        {
            txtEmpID.Clear();
            txtNIK.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bersihkan();
            FormMasterEmployee_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                if (mode == "insert")
                    cmd.CommandText = "INSERT INTO EMPLOYEE (EMPLOYEE_NIK, EMPLOYEE_NAME, EMPLOYEE_PHONE, EMPLOYEE_EMAIL, EMPLOYEE_USERNAME, EMPLOYEE_PASSWORD) VALUES " +
                        "(@nik,@name,@phone,@email,@user,@pass)";
                else if (mode == "update")
                    cmd.CommandText = "UPDATE EMPLOYEE SET EMPLOYEE_NIK = @nik, EMPLOYEE_NAME = @name, EMPLOYEE_PHONE = @phone, EMPLOYEE_EMAIL = @email, EMPLOYEE_PASSWORD=md5(@pass) " +
                        "WHERE EMPLOYEE_ID=@id";
                cmd.Parameters.AddWithValue("@id", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@nik", txtNIK.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass",txtPassword.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("1 Data Saved !");
                bersihkan();
                FormMasterEmployee_Load(sender, e);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mode = "update";
                lblMode.Text = "mode : " + mode;
                btnResign.Enabled = true;
                txtUsername.Enabled = false;
                txtEmpID.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_ID"].Value.ToString();
                txtNIK.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_NIK"].Value.ToString();
                txtName.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_NAME"].Value.ToString();
                txtPhone.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_PHONE"].Value.ToString();
                txtEmail.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_EMAIL"].Value.ToString();
                txtUsername.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_USERNAME"].Value.ToString();
                txtPassword.Text = dgvEmployee.Rows[e.RowIndex].Cells["EMPLOYEE_PASSWORD"].Value.ToString();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnResign_Click(object sender, EventArgs e)
        {
            try
            {
                if (mode == "update")
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE EMPLOYEE SET EMPLOYEE_IS_AVAILABLE = 0, EMPLOYEE_EXIT_DATE = now() " +
                        "WHERE EMPLOYEE_ID=@id";
                    cmd.Parameters.AddWithValue("@id", txtEmpID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("1 Employee Resigned !");
                    bersihkan();
                    FormMasterEmployee_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
