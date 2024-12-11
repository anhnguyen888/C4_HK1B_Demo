using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienUI.Entities
{
    // Lớp Khoa
    public class Khoa
    {
        // Mã khoa
        public string MaKhoa { get; set; }
        // Tên khoa
        public string TenKhoa { get; set; }
        
        // Phương thức khởi tạo mặc định
        public Khoa()
        {
           
        }

        // Phương thức khởi tạo có tham số
        public Khoa(string maKhoa, string tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }
    }
}
