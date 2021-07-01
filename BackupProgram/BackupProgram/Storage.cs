using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupProgram
{
    abstract class Storage
    {
        public string Medianame { get; set; }
        public string Model { get; set; }
        protected int filememory = 565;
        protected int infile_memory = 780;
        protected int countmedia;
        protected double time;
        protected double freememory;

        public virtual void Copy() { }
        
        public virtual double FreeMemory()
        {
            return 0;
        }
        public virtual void PrintDeviceInfo() { }
        
    }
}
