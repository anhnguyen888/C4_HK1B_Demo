using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienUI.Entities
{
    // Khai báo lớp sinh với thông tin mã số, họ tên, giới tính, điểm, khoa
    public class SinhVien
    {
        // Mã số sinh viên
        public string MaSo { get; set; }
        // Họ tên sinh viên
        public string HoTen { get; set; }
        // Giới tính
        public string GioiTinh { get; set; }
        // Điểm
        public double Diem { get; set; }
        // Khoa
        public string MaKhoa { get; set; }

        // Phương thức khởi tạo mặc định
        public SinhVien()
        {

        }

        // Phương thức khởi tạo có tham số
        public SinhVien(string maSo, string hoTen, string gioiTinh, double diem, string maKhoa)
        {
            MaSo = maSo;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Diem = diem;
            MaKhoa = maKhoa;
        }
    }
}
