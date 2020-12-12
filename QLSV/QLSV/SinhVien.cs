using System;
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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            dgvSV.DataSource = LoadExcel.dsSinhVien;
        }

        private void btnThoatSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
