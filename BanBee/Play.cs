using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBee
{
    internal class Play
    {
        List<Bee> bees = new List<Bee>();
        public void TaoList()
        {
            for(int i = 0; i < 30; i++)
            {
                if(i<10)
                        bees.Add(new BeeChua());
                else if(i < 20 && i>=10)            
                        bees.Add(new BeeDuc());
                else
                        bees.Add(new BeeTho());
            }
            
        }

        public void XuatList()
        {
            foreach (Bee bee in bees)
            {
                bee.sst();
            }
        }

        public void Ban()
        {
            for(int i = 0; i < bees.Count; i++)
            {
                Random rd = new Random();
                bees[i].power -= rd.Next(1, 5);
            }
        }
    }
}
