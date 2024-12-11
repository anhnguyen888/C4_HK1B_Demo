using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBee.Entities
{
    internal class Player
    {
        List<ConOng> conOngs = new List<ConOng>();

        public Player()
        {
            for (int i = 0; i < 10; i++)
            {
                conOngs.Add(new OngChua(90));
                conOngs.Add(new OngDuc(80));
                conOngs.Add(new OngTho(70));
            }
        }

        public void TanCongDanOng()
        {
            //xử lý trường hợp số random trùng nhau trong vòng lặp 
            Random random = new Random();

            foreach (var conOng in conOngs)
            {

                int sucManhTanCong = random.Next(1, 50);
                System.Threading.Thread.Sleep(1);
                conOng.TanCong(sucManhTanCong);
            }
        }

        public void XemTrangThai()
        {
            foreach (var conOng in conOngs)
            {
                Console.WriteLine("Loai: {0} - Suc manh hien tai: {1} - Trang thai: {2}", conOng.GetType().Name, conOng.SucManh, conOng.TrangThai == true ? "Song" : "Chet");
            }
        }

    }
}
