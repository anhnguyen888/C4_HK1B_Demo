using BanBee.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Play x = new Play();
            //x.TaoList();
            //x.XuatList();
            //x.Ban();
            //x.XuatList();
            //Console.ReadKey();

            Player player = new Player();

            while (true)
            {
                Console.WriteLine("1. Xem trang thai dan ong");
                Console.WriteLine("2. Tan cong dan ong");
                Console.WriteLine("3. Thoat");

                Console.Write("Chon: ");
                int chon = int.Parse(Console.ReadLine());

                switch(chon)
                {
                    case 1:
                        player.XemTrangThai();
                        break;
                    case 2:
                        player.TanCongDanOng();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
