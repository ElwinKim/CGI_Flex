using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class StatusChangeDTO
    {
        public int? MachineId {get; set;}
        public String NewStatus {get; set;}
        public String PartNumber {get; set;}
    }
}