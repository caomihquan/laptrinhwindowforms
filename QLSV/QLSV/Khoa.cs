﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = LoadExcel.dsKhoa;
        }
    }
}
