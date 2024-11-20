using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    internal class NhaQuanLy : NhanVien
    {
        public double BacLuong { get; set; }
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }

        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap bac luong: ");
            BacLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Bac luong: " + BacLuong);
            Console.WriteLine("Chuc vu: " + ChucVu);
            Console.WriteLine("So ngay cong: " + SoNgayCong);
        }
    }
}
