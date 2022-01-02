using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class MachinesDTO
    {
        public int MachineId {get; set;}
        public String MachineLabel {get; set;}
        public String MachineName {get; set;}
        public String Status {get; set;}
        public String PartNr {get; set;}
        public String PartMinCy {get; set;}
        public String PartMaxCy {get; set;}
        public String PartLoadTime {get; set;}
        public String PartMultiplier {get; set;}
        public String PartCount {get; set;}
        public String PartsRequired {get; set; }
        public String Operation {get; set;}
        public String Operator {get; set;}
        public int FeedrateOvr {get; set;}
        public int SpindleOvr {get; set;}
        public int RapidOvr {get; set;}
        public String EventDateTime {get; set;}
        public int Shift {get; set;}
        public String ShiftStart {get; set;}
        public int CycleTime {get; set;}
        public int CycleOnTime {get; set;}
        public int CycleOffTime {get; set;}
        public int OthersTime {get; set;}
        public int SetupTime {get; set;}             
    }
}