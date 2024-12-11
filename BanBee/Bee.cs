using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBee
{
    internal class Bee
    {

        public int power;
        public string type;
        public bool st;

        public Bee()
        {
            this.power = 0;
            this.type = "";
            this.st = true;
        }

        public void sst()
        {
            Console.WriteLine("Loai ong: " + this.type+ " Power: " + power+ " Status "+ st);
        }
    }

}
