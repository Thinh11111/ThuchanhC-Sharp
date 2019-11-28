using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinh1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap tong so sinh vien ");
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arraySinhVien = new SinhVien[n];
            Console.WriteLine("****************Nhap Danh Sach Sinh Vien********************");
            for(int i = 0; i < n; i++)
            {
                arraySinhVien[i] = new SinhVien();
                Console.WriteLine("Nhap Ma So Sinh Vien {0} ", i + 1);
                arraySinhVien[i].maSoSinhVien = Console.ReadLine();
                Console.WriteLine("Nhap ten sinh vien ");
                arraySinhVien[i].tenSv = Console.ReadLine();
                Console.WriteLine("Nhap Diem Trung Binh ");
                arraySinhVien[i].diemTB = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap khoa ");
                arraySinhVien[i].khoa = Console.ReadLine();
            }
            Console.WriteLine("**************Xuat Danh Sach SInh Vien*******************");
            foreach(SinhVien sv in arraySinhVien)
            {
                Console.WriteLine("MSSV {0} ", sv.maSoSinhVien);
                Console.WriteLine("Ten Sinh Vien {0} ", sv.tenSv);
                Console.WriteLine("Diem Trung Binh {0} ", sv.diemTB);
                Console.WriteLine("Khoa {0} ", sv.khoa);
            }

        }
    }
}
