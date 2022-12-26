using MySql.Data.MySqlClient;
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

namespace P9_1214073.view
{
    public partial class Nilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Nilai n_nil = new M_Nilai();
        string id;

        public void Tampil()
        {
            dataNilai.DataSource = koneksi.ShowData("SELECT id_nilai,matkul,kategori,t_nilai.npm,nama,nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");
            dataNilai.Columns[0].HeaderText = "ID";
            dataNilai.Columns[1].HeaderText = "MATKUL";
            dataNilai.Columns[2].HeaderText = "KATEGORI";
            dataNilai.Columns[3].HeaderText = "NPM";
            dataNilai.Columns[4].HeaderText = "NAMA";
            dataNilai.Columns[5].HeaderText = "NILAI";
        }
        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                cbnpm.Items.Add(reader.GetString("npm"));
            }reader.Close();
            koneksi.CloseConnection();
        }
        public Nilai()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            dataNilai.DataSource = koneksi.ShowData("SELECT" + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai" + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm" + "WHERE t_nilai.npm LIKE '%' '" + tbCariData.Text + "' '%' " + "OR matkul LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbangkatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        private void btnsimpan1_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Nilai1 n1 = new Nilai1();
                n_nil.Matkul = cbmatkul.Text;
                n_nil.Kategori = cbkategori.Text;
                n_nil.Npm = cbnpm.Text;
                n_nil.Nilai = tbnilai.Text;
               

                n1.Insert (n_nil);

              
                cbmatkul.SelectedIndex = -1;
                cbkategori.SelectedIndex = -1;
                cbnpm.SelectedIndex = -1;
                tbnilai.Text = "";
                Tampil();
            }
        }

        private void btnubah1_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Nilai1 n1 = new Nilai1();
                n_nil.Matkul = cbmatkul.Text;
                n_nil.Kategori = cbkategori.Text;
                n_nil.Npm = cbnpm.Text;
                n_nil.Nilai = tbnilai.Text;


                n1.Update(n_nil, id);


                cbmatkul.SelectedIndex = -1;
                cbkategori.SelectedIndex = -1;
                cbnpm.SelectedIndex = -1;
                tbnilai.Text = "";
                Tampil();
            }
        }

        private void btnhapus1_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(" Apakah anda yakin akan menghapus data ini?", "perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai1 n1 = new Nilai1();
                n1.Delete(id);
                Tampil();
            }
        }

        private void btnrefresh1_Click(object sender, EventArgs e)
        {
            cbmatkul.SelectedIndex = -1;
            cbkategori.SelectedIndex = -1;
            cbnpm.SelectedIndex = -1;
            tbnilai.Text = "";
            Tampil();
        }

        private void dataNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmatkul.Text = dataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbkategori.Text = dataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbnpm.Text = dataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbnilai.Text = dataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void GetNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa " + "WHERE npm = '" + cbnpm.Text + "'");
            while (reader.Read())
            {
                tbnama.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        private void tbnama_selectedIndexChanged (object sender, EventArgs e)
        {
            GetNamaMhs();
        }
        private void ExportExcel(DataGridView dataGrid, string searchData)
        {
            string Output = "";
            string Headers = "";

            // export judul
            for (int j = 0; j < dataGrid.ColumnCount; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";
            }
            Output += Headers + "\r\n";

            // Export data 
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string Line = "";
                for (int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(12345);
            // array tipe byte
            byte[] outputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(searchData, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);

            binary.Write(outputs, 0, outputs.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents ( *.xls)| *xsl";
            save.FileName = "Report Nilai.xls";
            if (save.ShowDialog () == DialogResult.OK)
            {
                ExportExcel(dataNilai, save.FileName);
            }
        }
    }
}
