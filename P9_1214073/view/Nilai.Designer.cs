namespace P9_1214073.view
{
    partial class Nilai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.btnubah1 = new System.Windows.Forms.Button();
            this.btnsimpan1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrefresh1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhapus1 = new System.Windows.Forms.Button();
            this.dataNilai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnpm = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.cbmatkul = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(494, 397);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(120, 20);
            this.tbCariData.TabIndex = 6;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // btnubah1
            // 
            this.btnubah1.Location = new System.Drawing.Point(47, 69);
            this.btnubah1.Name = "btnubah1";
            this.btnubah1.Size = new System.Drawing.Size(270, 23);
            this.btnubah1.TabIndex = 1;
            this.btnubah1.Text = "Ubah";
            this.btnubah1.UseVisualStyleBackColor = true;
            this.btnubah1.Click += new System.EventHandler(this.btnubah1_Click);
            // 
            // btnsimpan1
            // 
            this.btnsimpan1.Location = new System.Drawing.Point(47, 34);
            this.btnsimpan1.Name = "btnsimpan1";
            this.btnsimpan1.Size = new System.Drawing.Size(270, 23);
            this.btnsimpan1.TabIndex = 0;
            this.btnsimpan1.Text = "Simpan";
            this.btnsimpan1.UseVisualStyleBackColor = true;
            this.btnsimpan1.Click += new System.EventHandler(this.btnsimpan1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nilai";
            // 
            // btnrefresh1
            // 
            this.btnrefresh1.Location = new System.Drawing.Point(47, 130);
            this.btnrefresh1.Name = "btnrefresh1";
            this.btnrefresh1.Size = new System.Drawing.Size(270, 23);
            this.btnrefresh1.TabIndex = 3;
            this.btnrefresh1.Text = "Refresh";
            this.btnrefresh1.UseVisualStyleBackColor = true;
            this.btnrefresh1.Click += new System.EventHandler(this.btnrefresh1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnrefresh1);
            this.groupBox2.Controls.Add(this.btnhapus1);
            this.groupBox2.Controls.Add(this.btnubah1);
            this.groupBox2.Controls.Add(this.btnsimpan1);
            this.groupBox2.Location = new System.Drawing.Point(447, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tombol Action";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnhapus1
            // 
            this.btnhapus1.Location = new System.Drawing.Point(47, 98);
            this.btnhapus1.Name = "btnhapus1";
            this.btnhapus1.Size = new System.Drawing.Size(270, 23);
            this.btnhapus1.TabIndex = 2;
            this.btnhapus1.Text = "Hapus";
            this.btnhapus1.UseVisualStyleBackColor = true;
            this.btnhapus1.Click += new System.EventHandler(this.btnhapus1_Click);
            // 
            // dataNilai
            // 
            this.dataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNilai.Location = new System.Drawing.Point(6, 20);
            this.dataNilai.Name = "dataNilai";
            this.dataNilai.Size = new System.Drawing.Size(764, 170);
            this.dataNilai.TabIndex = 0;
            this.dataNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNilai_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataNilai);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Nilai";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matkul";
            // 
            // cbnpm
            // 
            this.cbnpm.FormattingEnabled = true;
            this.cbnpm.Location = new System.Drawing.Point(94, 99);
            this.cbnpm.Name = "cbnpm";
            this.cbnpm.Size = new System.Drawing.Size(133, 21);
            this.cbnpm.TabIndex = 5;
            this.cbnpm.SelectedIndexChanged += new System.EventHandler(this.cbangkatan_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbnama);
            this.groupBox3.Controls.Add(this.tbnilai);
            this.groupBox3.Controls.Add(this.cbmatkul);
            this.groupBox3.Controls.Add(this.cbkategori);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbnpm);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Input Nilai Check";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(254, 99);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(120, 20);
            this.tbnama.TabIndex = 7;
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(94, 130);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(120, 20);
            this.tbnilai.TabIndex = 7;
            // 
            // cbmatkul
            // 
            this.cbmatkul.FormattingEnabled = true;
            this.cbmatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Literasi Data",
            "PKN",
            "SIstem ERP",
            "General English I",
            "General English II"});
            this.cbmatkul.Location = new System.Drawing.Point(94, 38);
            this.cbmatkul.Name = "cbmatkul";
            this.cbmatkul.Size = new System.Drawing.Size(220, 21);
            this.cbmatkul.TabIndex = 13;
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "UAS",
            "UTS"});
            this.cbkategori.Location = new System.Drawing.Point(94, 67);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(220, 21);
            this.cbkategori.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(542, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export To excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCariData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Nilai";
            this.Text = "Nilai";
            this.Load += new System.EventHandler(this.Nilai_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNilai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Button btnubah1;
        private System.Windows.Forms.Button btnsimpan1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrefresh1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnhapus1;
        private System.Windows.Forms.DataGridView dataNilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnpm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbmatkul;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.Button button1;
    }
}