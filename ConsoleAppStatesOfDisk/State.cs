using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStatesOfDisk
{
    internal class State
    {
        public string UpdateTimestamp { get; set; }
        public string ComputerName { get; set; }
        public double DiskCFreeSpace { get; set; }
    }
}
