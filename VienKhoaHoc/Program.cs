using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();

            Console.WriteLine("1. Nhap nhan vien");
            Console.WriteLine("2. Xuat nhan vien");
            Console.WriteLine("3. Tinh luong");
            Console.WriteLine("4. Thoat");

            int chon = int.Parse(Console.ReadLine());
            while (chon != 4)
            {
                switch (chon)
                {
                    case 1:
                        app.Nhap();
                        break;
                    case 2:
                        app.Xuat();
                        break;
                    case 3:
                        app.XuatTongLuong();
                        break;
                    default:
                        Console.WriteLine("Chon khong hop le");
                        break;
                }

                Console.WriteLine("1. Nhap nhan vien");
                Console.WriteLine("2. Xuat nhan vien");
                Console.WriteLine("3. Tinh luong");
                Console.WriteLine("4. Thoat");

                chon = int.Parse(Console.ReadLine());
            }


        }
    }
}
