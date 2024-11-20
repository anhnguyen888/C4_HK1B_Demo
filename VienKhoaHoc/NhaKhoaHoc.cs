using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    internal class NhaKhoaHoc : NhaQuanLy
    {
        public int SoBaiBao { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so bai bao: ");
            SoBaiBao = int.Parse(Console.ReadLine());
        }
        override public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So bai bao: " + SoBaiBao);
        }
    }
}
