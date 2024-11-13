using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo menu có 3 lựa chọn
            Console.OutputEncoding = UnicodeEncoding.UTF8;

            //tạo danh sách sinh viên
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();

            //vòng lặp cho menu 
            while (true)
            {
                //hiển thị menu
                Console.WriteLine("Chương trình quản lý sinh viên");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Hiển thị danh sách sinh viên thuộc Khoa nhập vào từ bàn phím");
                Console.WriteLine("0. Thoát chương trình");

                //nhập lựa chọn từ người dùng
                Console.Write("Mời bạn chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());

                //xử lý lựa chọn
                switch (chon)
                {
                    case 1:
                        SinhVien sinhVien = new SinhVien();
                        sinhVien.Nhap();
                        danhSachSinhVien.Add(sinhVien);
                        break;
                    case 2:
                        Console.WriteLine("Bạn chọn chức năng hiển thị danh sách sinh viên");
                        foreach (SinhVien sv in danhSachSinhVien)
                        {
                            sv.Xuat();
                        }
                        break;
                    case 3:
                        //xuất danh sách sinh viên thuộc một khoa nào đó 
                        Console.WriteLine("Mời bạn nhập khoa cần tìm: ");
                        string khoa = Console.ReadLine();

                        //sắp xếp sinh viên tăng dần theo điểm trung bình
                        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));

                        // sắp xếp danh sách sinh viên theo thứ tự A-Z của họ tên sinh viên
                        danhSachSinhVien.Sort((sv1, sv2) => sv1.TenSinhVien.CompareTo(sv2.TenSinhVien));

                        //lấy danh sách sinh viên có điểm trung bình >= 5

                        List<SinhVien> danhSachSinhVienKhoa = danhSachSinhVien.FindAll(sv => sv.DiemTrungBinh >=5);

                        foreach (SinhVien sv in danhSachSinhVienKhoa)
                        {
                            sv.Xuat();
                        }

                        //tính tổng điểm của tất cả sinh viên
                        float tongDiem = danhSachSinhVien.Sum(sv => sv.DiemTrungBinh);
                        Console.WriteLine("Tổng điểm của tất cả sinh viên: " + tongDiem);


                        // xuất sinh viên có điểm trung bình cao nhất thuộc khoa CNTT 
                        List<SinhVien> danhSachSinhVienKhoaCNTT = danhSachSinhVien.FindAll(sv => sv.Khoa == "CNTT");
                        // lấy sinh viên có điểm trung bình cao nhất của danhSachSinhVienKhoaCNTT
                        SinhVien sinhVienDiemCaoNhat = danhSachSinhVienKhoaCNTT.OrderByDescending(sv => sv.DiemTrungBinh).First();


                        // lấy danh sách sinh viên có điểm xuất sắc từ 9 trở lên
                        List<SinhVien> danhSachSinhVienXuatSac = danhSachSinhVien.FindAll(sv => sv.DiemTrungBinh >= 9);

                        // lấy danh sách sinh viên có điểm giỏi từ 8 đến 8.9
                        List<SinhVien> danhSachSinhVienGioi = danhSachSinhVien.FindAll(sv => sv.DiemTrungBinh >= 8 && sv.DiemTrungBinh < 9);

                        // đếm số lượng sinh viên điểm giỏi 
                        int soLuongSinhVienGioi = danhSachSinhVienGioi.Count;

                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        return;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            }
        }
    }
}
