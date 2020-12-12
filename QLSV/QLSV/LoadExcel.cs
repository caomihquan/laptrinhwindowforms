using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using QLSV.model;

namespace QLSV
{
    public static class LoadExcel
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

            ws = wb.Worksheets[3];
            i++;
            SinhVien sv;
            while (ws.Cells[i, 1].Value != null)
            {
                sv = new SinhVien();
                sv.MSSV = ws.Cells[i, 1].Value.ToString();
                sv.HoTen = ws.Cells[i, 2].Value.ToString();
                sv.NgaySinh = ws.Cells[i, 3].Value;
                sv.GioiTinh = ws.Cells[i, 4].Value.ToString();
                sv.DiaChi = ws.Cells[i, 5].Value.ToString();
                sv.MaLop = ws.Cells[i, 6].Value.ToString();
                sv.MatKhau = ws.Cells[i, 7].Value.ToString();
                dsSinhVien.Add(sv);
                ++i;
            }
        }
    }
}
