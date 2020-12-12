using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.model;

namespace Project
{
    public partial class dangnhap : Form
    {
       

        private void btndangnhap_Click(object sender, EventArgs e)
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
    }
}
