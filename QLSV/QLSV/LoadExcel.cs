using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using Project.model;

namespace QLSV
{
    class LoadExcel
    {
        static string path = @"Database.xlsx";
        static _Application excel = new _Excel.Application();
        static Workbook wb;
        static Worksheet ws;
        static Worksheet ws1;
        static Worksheet ws2;
        public static List<SinhVien> dsSinhVien;
        public static List<Khoa> dsKhoa;
        public static List<Lop> dsLop;
        static LoadExcel()
        {
            wb = excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory + path);
            dsSinhVien = new List<SinhVien>();
            dsKhoa = new List<Khoa>();
            dsLop = new List<Lop>();

            ReadKhoa(1);
            ReadSV(1);
            ReadLop(1);
            excel.Quit();
        }
        private static void ReadKhoa(int i)
        {
            ws1 = wb.Worksheets[1];
            i++;
            Khoa khoa;
            while (ws1.Cells[i, 1].Value != null)
            {
                khoa = new Khoa();
                khoa.MaKhoa = ws1.Cells[i, 1].Value;
                khoa.TenKhoa = ws1.Cells[i, 2].Value;
                khoa.dsLop = new List<Lop>();
                dsKhoa.Add(khoa);
                ++i;
            }
        }
        private static void ReadSV(int i)
        {

        }
        private static void ReadLop(int i)
        {
            ws2 = wb.Worksheets[2];
            i++;
            Lop lop1;
            while (ws2.Cells[i, 1].Value != null)
            {
                lop1 = new Lop();
                lop1.MaLop = ws2.Cells[i, 1].Value;
                lop1.TenLop = ws2.Cells[i, 2].Value;
                lop1.SiSo = ws2.Cells[i, 4].Value;
                string maKhoa = ws2.Cells[i, 3].Value.ToString();

                lop1.NamNhapHoc = ws2.Cells[i, 5].Value;
                lop1.dsSV = new List<SinhVien>();
                foreach (Khoa data in dsKhoa)
                {
                    if (maKhoa.Equals(data.MaKhoa))
                    {
                        data.dsLop.Add(lop1);
                        break;
                    }
                }
                foreach (SinhVien sv in dsSinhVien)
                {
                    if (sv.MaLop.Equals(lop1.MaLop))
                        lop1.dsSV.Add(sv);
                }
                dsLop.Add(lop1);
            }
        }
    }
}
