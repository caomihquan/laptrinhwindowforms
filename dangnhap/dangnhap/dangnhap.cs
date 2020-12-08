using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hàm kết nối sql
using System.Data.SqlClient;
using System.Data;
namespace dangnhap
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

      


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtdangnhap_Click(object sender, EventArgs e){
        
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
               "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Close();
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
