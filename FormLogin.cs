using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APP_DB_RetailShop
{
    public partial class FormLogin : Form
    {
        public MySqlConnection conn;
        public string empID;

        public FormLogin()
        {
            InitializeComponent();
            loginCredentials();
        }

        private void loginCredentials()
        {
            try
            {
                string fileName = "credentials.txt";
                string[] lines = File.ReadAllLines(fileName);

                conn = new MySqlConnection("SERVER=localhost; UID=" + lines[0] + "; PWD="+ lines[1] +"; DATABASE="+ lines[2] );
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT fCheckLogin('" + txtUser.Text + "','" + txtPass.Text + "')";
                // SELECT fCheckLogin('david', 'pass');
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
