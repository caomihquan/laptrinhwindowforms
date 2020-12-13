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
using QLSV;

namespace QLSV
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSV;
        private void dangnhap_Load(object sender, EventArgs e)
        {
            dsSV = LoadExcel.dsSinhVien;

        }

      

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            bool checkDN = false;
            if (!String.IsNullOrEmpty(txttaikhoan.Text) || !String.IsNullOrEmpty(txtmatkhau.Text))
            {
                foreach (SinhVien data in dsSV)
                {
                    if (txttaikhoan.Text.Equals(data.MSSV))
                    {
                        if (txtmatkhau.Text.Equals(data.MatKhau))
                        {
                            checkDN = true;
                            MainPage form = new MainPage();
                            form.ShowDialog();

                        }
                    }
                }
            }
            txtmatkhau.Text = "";
            txttaikhoan.Text = "";
            if (checkDN == false)
                MessageBox.Show("Sai TK or MK");
        }

        private void lblthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
