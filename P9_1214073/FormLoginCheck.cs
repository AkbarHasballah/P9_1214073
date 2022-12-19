using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using P9_1214073.controller;

namespace P9_1214073
{
    public partial class FormLoginCheck : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        CekLogin login1 = new CekLogin();

        public FormLoginCheck()
        {
            server = "localhost";
            database = "ulbi";
            uid = "root";
            password = "";

            string connString;
            connString = "Server=localhost;Database=ulbi;Uid=root;Pwd=;";

            conn = new MySqlConnection(connString);
            InitializeComponent();
        }
        public bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM usercek WHERE akun = '{user}' AND paswot = '{pass}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception )
            {
                conn.Close();
                return false;
            }
        }
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("konek ke sever gagal om");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpaswot.Text;

            if (IsLogin(user, pass))
            {
                this.Hide();
                MessageBox.Show($"Login sukses buos \rWelcome {user} !", "Berhasil", MessageBoxButtons.OK);
                parentform panggil = new parentform();
                panggil.Show();

            }
            else if (user == "" && pass == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong om");
            }
            else if (user == "" )
            {
                MessageBox.Show("Username tidak boleh kosong!!");
            }
            else if (pass == "")
            {
                MessageBox.Show("Password tidak boleh kosong!!");
            }
            else
            {
                MessageBox.Show("Login Gagal Buoss!!", "Gagal", MessageBoxButtons.OK);
            }
        }

        private void FormLoginCheck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpaswot.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = txtusername.Text;
                string password = txtpaswot.Text;

                bool status = login1.cek_login1(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    parentform pform = new parentform();
                    pform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
    }
}
