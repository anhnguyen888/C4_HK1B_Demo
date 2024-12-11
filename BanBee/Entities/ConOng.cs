using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBee.Entities
{
    internal class ConOng
    {
        public int SucManh { get; set; }

        public bool TrangThai {
            get {
                return SucManh > 0;
            }
        }

        public ConOng(int nguongSucManh)
        {
            SucManh = nguongSucManh;
        }
        public void TanCong(int sucManhTanCong)
        {
            if (TrangThai)
            {
                SucManh = (SucManh - sucManhTanCong) < 0 ? 0 : SucManh - sucManhTanCong;
            }
        }
    }
}
