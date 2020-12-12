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

        }
        private static void ReadSV(int i)
        {

        }
        private static void ReadLop(int i)
        {

        }
    }
}
