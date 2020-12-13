using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.model;

namespace QLSV
{
    public partial class ThemSV : Form
    {
        public ThemSV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTen.Text) || !String.IsNullOrEmpty(txtMK.Text))
            {
                SinhVien sv = new SinhVien();
                sv.HoTen = txtTen.Text;
                sv.GioiTinh = cmbGioiTinh.SelectedItem.ToString();

            }
        }

        private void ThemSV_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbKhoa.DataSource = LoadExcel.dsKhoa;
        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLop.DataSource = LoadExcel.dsKhoa[cmbKhoa.SelectedIndex].dsLop;
        }
    }
}
