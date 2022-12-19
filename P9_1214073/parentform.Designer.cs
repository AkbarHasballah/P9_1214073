namespace P9_1214073
{
    partial class parentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parentform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataMasterToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem,
            this.dataMahasiswaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            this.dataMasterToolStripMenuItem.Click += new System.EventHandler(this.dataMasterToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputNilaiToolStripMenuItem});
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // inputNilaiToolStripMenuItem
            // 
            this.inputNilaiToolStripMenuItem.Name = "inputNilaiToolStripMenuItem";
            this.inputNilaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputNilaiToolStripMenuItem.Text = "Input Nilai";
            this.inputNilaiToolStripMenuItem.Click += new System.EventHandler(this.inputNilaiToolStripMenuItem_Click);
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            this.dataMahasiswaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            this.dataMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dataMahasiswaToolStripMenuItem.Text = "Help";
            this.dataMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataMahasiswaToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // parentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "parentform";
            this.Text = "parentform";
            this.Load += new System.EventHandler(this.parentform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputNilaiToolStripMenuItem;
    }
}