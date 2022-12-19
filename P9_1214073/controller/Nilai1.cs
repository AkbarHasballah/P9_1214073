using P9_1214073.model;
using P9_1214073.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214073.controller
{
    class Nilai1
    {
        // Memanggil class koneksi dan membuat  objek baru
        Koneksi koneksi = new Koneksi();
        //Method insert
        public bool Insert(M_Nilai nilai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_nilai (matkul, kategori, npm, nilai) VALUES ('" + nilai.Matkul + "', '" + nilai.Kategori + "','" + nilai.Npm  + "','" + nilai.Nilai + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        // Method Update
        public bool Update(M_Nilai nilai, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_nilai (matkul, kategori, npm, nilai) VALUES ('" + nilai.Matkul + "', '" + nilai.Kategori + "','" + nilai.Npm + "','" + nilai.Nilai + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        // method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM n_nilai WHERE kategori='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
