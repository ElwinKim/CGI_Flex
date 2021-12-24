using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class GetAMachineDTO
    {
        public int MachineId {get; set;}
        public int EnetMachineId {get; set;}
        public String MachineName {get; set;}
        public String EnetMachineName {get; set;} 
        public String Status {get; set;}
        public String PartNr {get; set;}
        public String Operation {get; set;}
        public String Operator {get; set;}
        public int FeedrateOvr {get; set;}
        public int SpindleOvr {get; set;}
        public int RapidOvr {get; set;}
        public String LastEventDateTime {get; set;}
        public int Shift {get; set;}
        public String ShiftStart {get; set;}
        public int TotalCycleTime {get; set;}
        public int TotalCycleOnTime {get; set;}
        public int TotalCycleOffTime {get; set;}
        public int TotalSetupTime {get; set;}
        public int OthersTime {get; set;}

    }
}