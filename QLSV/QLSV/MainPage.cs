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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            Khoa fromkhoa = new Khoa();
            fromkhoa.ShowDialog();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            Lop formlop = new Lop();
            formlop.ShowDialog();
        }
    }
}
