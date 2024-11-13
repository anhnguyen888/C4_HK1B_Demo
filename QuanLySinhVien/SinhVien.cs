using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string Khoa { get; set; }
        public float DiemTrungBinh { get; set; }

        //hàm nhập sinh viên từ bàn phím
        public void Nhap()
        {
            Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            MaSinhVien = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập tên sinh viên: ");
            TenSinhVien = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập khoa: ");
            Khoa = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập điểm trung bình: ");
            DiemTrungBinh = float.Parse(Console.ReadLine());
        }
        //hàm xuất sinh viên 
        public void Xuat()
        {
            Console.WriteLine("Mã sinh viên: " + MaSinhVien);
            Console.WriteLine("Tên sinh viên: " + TenSinhVien);
            Console.WriteLine("Khoa: " + Khoa);
            Console.WriteLine("Điểm trung bình: " + DiemTrungBinh);
        }
    }
}
