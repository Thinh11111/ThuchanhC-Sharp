using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinh1
{
    class Program
    {
        private static List<SinhVien> LayListSinhVienTuBanPhim()
        {
            List<SinhVien> dsSinhVien = new List<SinhVien>();
            Console.WriteLine("Nhap tong so sinh vien ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************Nhap Danh Sach Sinh Vien********************");
            for (int i = 0; i < n; i++)
            {
                SinhVien Temp = new SinhVien();
                Temp.InPut();
                dsSinhVien.Add(Temp); //dua doi tuong temp vao list
            }
            return dsSinhVien;
        }
        private static void XuatDSSinhVien(List<SinhVien> dsSinhVien)
        {
            
            foreach (SinhVien sv in dsSinhVien)
            {
                sv.Show();
            }
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Nhap tong so sinh vien ");
            int n = Convert.ToInt32(Console.ReadLine());
            //SinhVien[] arraySinhVien = new SinhVien[n];
            List<SinhVien> dsSinhVien = new List<SinhVien>();
            Console.WriteLine("****************Nhap Danh Sach Sinh Vien********************");
            for(int i=0;i<n;i++)
            {
                SinhVien Temp = new SinhVien();
                Temp.InPut();
                dsSinhVien.Add(Temp); //dua doi tuong temp vao list
            }*/
            /*for(int i = 0; i < n; i++)
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
            }*/
            //Console.WriteLine("**************Xuat Danh Sach SInh Vien*******************");
            /*foreach(SinhVien sv in arraySinhVien)
            {
                Console.WriteLine("MSSV {0} ", sv.maSoSinhVien);
                Console.WriteLine("Ten Sinh Vien {0} ", sv.tenSv);
                Console.WriteLine("Diem Trung Binh {0} ", sv.diemTB);
                Console.WriteLine("Khoa {0} ", sv.khoa);
                Console.WriteLine("\n");
            }*/
            /*foreach (SinhVien sv in dsSinhVien)
            {
                sv.Show();
            }
            Console.WriteLine("CAC sv khoa CNTT ");
            foreach (SinhVien sv in dsSinhVien)
            {
                Console.WriteLine("{0}",)
            }*/
            //List<SinhVien> dsSinhVien = new List<SinhVien>();


            List<SinhVien> dsSinhVien = LayListSinhVienTuBanPhim();


            Console.WriteLine("**************Xuat Danh Sach Sinh Vien*******************");
            XuatDSSinhVien(dsSinhVien);
            
            List<SinhVien> listSVKhoaCNTT = dsSinhVien.Where(p => p.khoa == "CNTT").ToList();
            if (listSVKhoaCNTT.Count > 0)
            {
                Console.WriteLine("***********DS Sinh vien khoa CNTT********** ");
                XuatDSSinhVien(listSVKhoaCNTT);
            }
            else
            {
                Console.WriteLine("ko tim thay sv khoa CNTT ");
            }
            List<SinhVien> listSortStudent = dsSinhVien.OrderBy(p =>p.diemTB).ToList();
            Console.WriteLine("***********DS Sinh vien co diem trung binh tang dan********** ");
            XuatDSSinhVien(listSortStudent);
            //int totalStudent = dsSinhVien.Where(dsSinhVien.Max(p=>p.diemTB) && p.khoa =="CNTT").Count();
            //List<SinhVien> listSVKhoaCNTTandDiemtbMax = dsSinhVien.Where(p => p.khoa == "CNTT").ToList() && dsSinhVien.Max(p => p.diemTB);

            float maxScore = listSVKhoaCNTT.Max(p => p.diemTB);
            var listMax = listSVKhoaCNTT.Where(p => p.diemTB == maxScore);
            XuatDSSinhVien(listMax);
            

        }
    }
}
