using P9_1214073.controller;
using P9_1214073.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_1214073
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        string id;

        public void Tampil()
        {
            dataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            dataMahasiswa.Columns[0].HeaderText = "NPM";
            dataMahasiswa.Columns[1].HeaderText = "Nama";
            dataMahasiswa.Columns[2].HeaderText = "Angkatan";
            dataMahasiswa.Columns[3].HeaderText = "Alamat";
            dataMahasiswa.Columns[4].HeaderText = "Email";
            dataMahasiswa.Columns[5].HeaderText = "No.HP";
        }
        private void tambah()
        {
          
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(" Apakah anda yakin akan menghapus data ini?", "perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(id);
                Tampil();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnpm.Text == "" || txtnama.Text == "" || cbangkatan.SelectedIndex == -1 || txtalamat.Text == "" || txtemail.Text == "" || txtnohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = txtnpm.Text;
                m_mhs.Nama = txtnama.Text;
                m_mhs.Angkatan = cbangkatan.Text;
                m_mhs.Alamat = txtalamat.Text;
                m_mhs.Email = txtemail.Text;
                m_mhs.Nohp = txtnohp.Text;

                mhs.Update(m_mhs, id);

                txtnpm.Text = "";
                txtnama.Text = "";
                cbangkatan.SelectedIndex = -1;
                txtalamat.Text = "";
                txtemail.Text = "";
                txtnohp.Text = "";
                Tampil();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtnpm.Text == "" || txtnama.Text == "" || cbangkatan.SelectedIndex == -1 || txtalamat.Text == "" || txtemail.Text == "" || txtnohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = txtnpm.Text;
                m_mhs.Nama = txtnama.Text;
                m_mhs.Angkatan = cbangkatan.Text;
                m_mhs.Alamat = txtalamat.Text;
                m_mhs.Email = txtemail.Text;
                m_mhs.Nohp = txtnohp.Text;

                mhs.Insert (m_mhs);

                txtnpm.Text = "";
                txtnama.Text = "";
                cbangkatan.SelectedIndex = -1;
                txtalamat.Text = "";
                txtemail.Text = "";
                txtnohp.Text = "";
                Tampil();
            }

        }

        private void dataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnpm.Text= dataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnama.Text = dataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbangkatan.Text = dataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtalamat.Text = dataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtnohp.Text = dataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            dataMahasiswa.DataSource = koneksi.ShowData("SELECT FROM t_mahasiswa WHERE npm LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData + "' '%'");
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            txtnpm.Text = "";
            txtnama.Text = "";
            cbangkatan.SelectedIndex = -1;
            txtalamat.Text = "";
            txtemail.Text = "";
            txtnohp.Text = "";
            Tampil();
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
       
       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
