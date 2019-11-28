using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinh1
{
    class SinhVien
    {
        public string maSoSinhVien { get; set; }
        public string tenSv { get; set; }
        public float diemTB { get; set; }
        public string khoa { get; set; }

        public SinhVien() { }
        public SinhVien(string mssv, string t, float d, string k)
        {
            maSoSinhVien = mssv;
            tenSv = t;
            diemTB = d;
            khoa = k;
        }
        public void InPut()
        {
            Console.WriteLine("Nhap Ma So Sinh Vien ");
            maSoSinhVien = Console.ReadLine();
            Console.WriteLine("Nhap ten sinh vien ");
            tenSv = Console.ReadLine();
            Console.WriteLine("Nhap Diem Trung Binh ");
            diemTB = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoa ");
            khoa = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void Show()
        {
            Console.WriteLine("MSSV {0} ", maSoSinhVien);
            Console.WriteLine("Ten SInh Vien {0} ", tenSv);
            Console.WriteLine("Diem TB {0} ", diemTB);
            Console.WriteLine("Khoa {0} ", khoa);
            Console.WriteLine("\n");
        }
    }
}
