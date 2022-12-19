using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P9_1214073.controller
{
    internal class CekLogin
    {
        Koneksi koneksi = new Koneksi();
        public bool cek_login1(string username, string password)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM usercek WHERE akun='" +
                    username + "' AND paswot='" + password + "'");
                if (reader.Read())
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            koneksi.CloseConnection();
            return false;
        }
    }
}
