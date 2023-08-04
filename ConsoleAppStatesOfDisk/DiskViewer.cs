using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStatesOfDisk
{
    internal class DiskViewer
    {
        public static double GetDiskCFreeSpace()
        {
            double freeSpace = 0;
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript("(Get-PSDrive C | Select-Object Free).Free / (1024 * 1024)");
                var results = powerShell.Invoke();
                if (results.Count > 0 && results[0].BaseObject is double)
                {
                    freeSpace = (double)results[0].BaseObject;
                }
            }
            return freeSpace;
        }
        public static string GetComputerName()
        {
            return Environment.MachineName;
        }
        
    }
}
