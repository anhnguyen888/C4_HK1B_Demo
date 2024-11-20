using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    internal class App
    {
        List<NhanVien> nhanViens = new List<NhanVien>();

        //xuất tổng lương của mỗi loại nhân viên 
        public void XuatTongLuong()
        {
            double tongLuongPTN = 0;
            double tongLuongQL = 0;
            double tongLuongKH = 0;
            foreach (NhanVien nv in nhanViens)
            {
                if (nv is NhanVienPTN)
                {
                    tongLuongPTN += nv.TinhLuong();
                }
                else if (nv is NhaQuanLy)
                {
                    tongLuongQL += nv.TinhLuong();
                }
                else if (nv is NhaKhoaHoc)
                {
                    tongLuongKH += nv.TinhLuong();
                }
            }
            Console.WriteLine("Tong luong nhan vien phong thi nghiem: " + tongLuongPTN);
            Console.WriteLine("Tong luong nha quan ly: " + tongLuongQL);
            Console.WriteLine("Tong luong nha khoa hoc: " + tongLuongKH);
        }

        public void Xuat()
        {
            foreach (NhanVien nv in nhanViens)
            {
                nv.Xuat();
            }
        }
        public void Nhap()
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1. Nhan vien phong thi nghiem");
                Console.WriteLine("2. Nha quan ly");
                Console.WriteLine("3. Nha khoa hoc");
                Console.Write("Chon loai nhan vien: ");
                int chon = int.Parse(Console.ReadLine());
                NhanVien nv = null;
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienPTN();
                        break;
                    case 2:
                        nv = new NhaQuanLy();
                        break;
                    case 3:
                        nv = new NhaKhoaHoc();
                        break;
                }
                nv.Nhap();
                nhanViens.Add(nv);
            }
        }
    }
}
