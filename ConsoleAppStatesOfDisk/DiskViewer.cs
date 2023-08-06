using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Net.NetworkInformation;
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


        public static string? GetMACAddress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    PhysicalAddress physicalAddress = networkInterface.GetPhysicalAddress();
                    return physicalAddress.ToString();
                }
            }
            return null;
        }

        public static string GetJsonPCInfo()
        {
            var mac = GetMACAddress();
            if(mac == null )
            {
                throw new NetworkInformationException();
            }

            return JsonConvert.SerializeObject(new State
            {
                Id = mac,
                UpdateTimestamp = string.Format("{0:O}", DateTime.Now.ToUniversalTime()),
                ComputerName = GetComputerName(),
                DiskCFreeSpace = GetDiskCFreeSpace()
            });
        }
    }
}
