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
    }
}
