﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214073
{
    public partial class parentform : Form
    {
        public parentform()
        {
            InitializeComponent();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void parentform_Load(object sender, EventArgs e)
        {

        }

        private void dataMahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 newulbi = new Form1();
            newulbi.MdiParent = this;
            newulbi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutme newAboutMe = new aboutme();
            newAboutMe.MdiParent = this;
            newAboutMe.Show();
        }
    }
}