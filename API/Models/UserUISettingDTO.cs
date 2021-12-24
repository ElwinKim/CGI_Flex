using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UserUISettingDTO
    {
        public int ShowMachineLabel {get; set;}
        public int ShowMachineName {get; set;}
        public String CONStatusColor {get; set;}
        public String COFFStatusColor {get; set;}
        public String SetupStatusColor {get; set;}
        public String OtherStatusColor {get; set;}
        public int ShowPartCount {get; set;}
        public int ShowOperator {get; set;}

    }
}