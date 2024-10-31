using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APP_DB_RetailShop
{
    public partial class FormLogin : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; PWD=root; DATABASE=db_retailshop");
        public string empID;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT fCheckLogin('" + txtUser.Text + "','" + txtPass.Text + "')";

                conn.Open();
                empID = (string)cmd.ExecuteScalar();
                conn.Close();

                if (empID.Equals(""))
                {
                    MessageBox.Show("Login GAGAL. Cek Kembali Username / Password !");
                    txtUser.Focus();
                }
                else
                {
                    MessageBox.Show("Login Berhasil");
                    FormMenu fMenu = new FormMenu(conn, empID);
                    fMenu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnLogin_Click(sender,e);
        }
    }
}
