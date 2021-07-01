using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupProgram
{
    class Flash:Storage
    {
        public double speed;  //Mb/s
        public double memory; //Gb

        public override void Copy()
        {
            double secondtime = 780 / speed;
            int count = Convert.ToInt32((filememory * 1024) / 780);

            countmedia = Convert.ToInt32(filememory / memory);
            time = count * secondtime;
            Console.WriteLine($"Count Meida:{countmedia}");
            if (time > 3600)
            {
                Console.WriteLine($"Copy time:{Convert.ToInt32(time / 3600)} hour ");
            }
            if (time > 60)
            {
                Console.WriteLine($"Copy time:{Convert.ToInt32(time / 60)} minute {Convert.ToInt32(time - (Convert.ToInt32(time / 60) * 60))} second ");
            }
        }
        public override double  FreeMemory()
        {
            if ((filememory * 1024) > (memory * countmedia * 1024))
            {
                freememory = (filememory * 1024) - (memory * countmedia * 1024);
                return freememory;
            }
            else if ((filememory * 1024) < (memory * countmedia * 1024))
            {
                freememory = (memory * countmedia * 1024) - (filememory * 1024);
                return freememory;
            }
            return 0;
        }

        public override void PrintDeviceInfo() {
            Console.WriteLine($"Medianame->{Medianame}");
            Console.WriteLine($"Model->{Model}");
            Console.WriteLine($"Speed->{speed} Mb/s");
            Console.WriteLine($"Memory->{memory} Gb");
        }
    }
}
