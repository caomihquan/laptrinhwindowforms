using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public double SiSo { get; set; }
        public double NamNhapHoc { get; set; }
        public List<SinhVien> dsSV { get; set; }
    }
}
