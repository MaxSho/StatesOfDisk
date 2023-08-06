using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStatesOfDisk
{
    internal class State
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("updateTimestamp")] 
        public string? UpdateTimestamp { get; set; }
        [JsonProperty("computerName")]
        public string? ComputerName { get; set; }
        [JsonProperty("diskCFreeSpace")]
        public double? DiskCFreeSpace { get; set; }
    }
}
