using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class MobileController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Machines()
        {
            List<MachinesDTO> machines = new List<MachinesDTO>();

            machines.Add(new MachinesDTO
            {
                MachineId = 1,
                MachineLabel = "MC-01",
                MachineName = "FANUC-SIM",
                Status = "CYCLE OFF",
                PartNr = "BBC123",
                PartMinCy = "120",
                PartMaxCy = "180",
                PartLoadTime = "120",
                PartMultiplier = "1",
                PartCount = "10",
                PartsRequired = "1000",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                EventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                CycleTime = 47132,
                CycleOnTime = 3000,
                CycleOffTime = 36000,
                OthersTime = 3600,
                SetupTime = 2088
            });
            machines.Add(
            new MachinesDTO
            {
                MachineId = 2,
                MachineLabel = "MCH02",
                MachineName = "FANUC-SIM",
                Status = "SETUP",
                PartNr = "ABC123",
                PartMinCy = "120",
                PartMaxCy = "180",
                PartLoadTime = "120",
                PartMultiplier = "1",
                PartCount = "10",
                PartsRequired = "1000",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                EventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                CycleTime = 25000,
                CycleOnTime = 12000,
                CycleOffTime = 7800,
                OthersTime = 3200,
                 SetupTime = 4000,
            });
            machines.Add(new MachinesDTO
            {
                MachineId = 3,
                MachineLabel = "MCH03",
                MachineName = "MATSURA VX100",
                Status = "CYCLE ON",
                PartNr = "ABC123",
                PartMinCy = "120",
                PartMaxCy = "180",
                PartLoadTime = "120",
                PartMultiplier = "1",
                PartCount = "10",
                PartsRequired = "1000",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                EventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                CycleTime = 17253,
                CycleOnTime = 2100,
                CycleOffTime = 1800,
                OthersTime = 1500,
                SetupTime = 0,
            }
            );

            machines.Add(new MachinesDTO
            {
                MachineId = 4,
                MachineLabel = "MCH03",
                MachineName = "FANUC-SIM",
                Status = "OTHERS",
                PartNr = "ABC123",
                PartMinCy = "120",
                PartMaxCy = "180",
                PartLoadTime = "120",
                PartMultiplier = "1",
                PartCount = "10",
                PartsRequired = "1000",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                EventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                CycleTime = 78900,
                CycleOnTime = 12500,
                CycleOffTime = 29400,
                OthersTime = 20000,
                SetupTime = 12000,
            }
            );

            return Ok(machines);
        }

        [HttpGet("{MachineId}")]
        public async Task<IActionResult> Machine(int? MachineId)
        {
            MachinesDTO machine = new MachinesDTO();
            if(MachineId == null)
            {
                return BadRequest("You must enter Machine Id");
            }
            else if(MachineId == 1){
                machine = new MachinesDTO
                {
                    MachineId = 1,
                    MachineLabel = "MC-01",
                    MachineName = "FANUC-SIM",
                    Status = "CYCLE OFF",
                    PartNr = "BBC123",
                    PartMinCy = "120",
                    PartMaxCy = "180",
                    PartLoadTime = "120",
                    PartMultiplier = "1",
                    PartCount = "10",
                    PartsRequired = "1000",
                    Operation = "Operation",
                    Operator = "Operator",
                    FeedrateOvr = 0,
                    SpindleOvr = 0,
                    RapidOvr = 0,
                    EventDateTime = "2021-09-15T22:00:00",
                    Shift = 0,
                    ShiftStart = "0001-01-01T00:00:00",
                    CycleTime = 47132,
                    CycleOnTime = 3000,
                    CycleOffTime = 36000,
                    OthersTime = 3600,
                    SetupTime = 2088
                };
            }
            else if(MachineId == 2){
                machine = new MachinesDTO
                {
                    MachineId = 2,
                    MachineLabel = "MCH02",
                    MachineName = "FANUC-SIM",
                    Status = "SETUP",
                    PartNr = "ABC123",
                    PartMinCy = "120",
                    PartMaxCy = "180",
                    PartLoadTime = "120",
                    PartMultiplier = "1",
                    PartCount = "10",
                    PartsRequired = "1000",
                    Operation = "Operation",
                    Operator = "Operator",
                    FeedrateOvr = 0,
                    SpindleOvr = 0,
                    RapidOvr = 0,
                    EventDateTime = "2021-09-15T22:00:00",
                    Shift = 0,
                    ShiftStart = "0001-01-01T00:00:00",
                    CycleTime = 25000,
                    CycleOnTime = 12000,
                    CycleOffTime = 7800,
                    OthersTime = 3200,
                    SetupTime = 4000,
                };
            }
            else if(MachineId == 3){
                machine = new MachinesDTO
            {
                MachineId = 3,
                MachineLabel = "MCH03",
                MachineName = "MATSURA VX100",
                Status = "CYCLE ON",
                PartNr = "ABC123",
                PartMinCy = "120",
                PartMaxCy = "180",
                PartLoadTime = "120",
                PartMultiplier = "1",
                PartCount = "10",
                PartsRequired = "1000",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                EventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                CycleTime = 17253,
                CycleOnTime = 2100,
                CycleOffTime = 1800,
                OthersTime = 1500,
                SetupTime = 0,
            };
            }
            else if(MachineId == 4){
                machine = new MachinesDTO
            {
                MachineId = 4,
                MachineLabel = "MCH03",
                MachineName = "FANUC-SIM",
                Status = "OTHERS",
                PartNr = "ABC123",
                PartMinCy = "120",
                PartMaxCy = "180",
                PartLoadTime = "120",
                PartMultiplier = "1",
                PartCount = "10",
                PartsRequired = "1000",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                EventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                CycleTime = 78900,
                CycleOnTime = 12500,
                CycleOffTime = 29400,
                OthersTime = 20000,
                SetupTime = 12000,
            };
            }
            else{
                return BadRequest();
            }
            return Ok(machine);
        }

        [HttpGet("{MachineId}")]
        public async Task<IActionResult> AvailableCommand(int? MachineId)
        {
            if(MachineId == null)
            {
                return BadRequest("You must enter Machine Id");
            }
            
            String[] commands = 
            {
                "CYCLE ON",
                "CYCLE OFF",
                "PRODUCTION",
                "SETUP",
                "MAINTENANCE",
                "TOOL MISSING",
                "PROGRAM ERROR",
                "TOOL BREAKAGE",
                "QC - FIRST PIECE",
                "QC - IN PROCESS",
                "NO OPERATOR",
                "OTHER FAILURE",
                "DOWNLOAD ISSUE",
                "OUT OF WORK",
                "OTHER UNSCH",
                "PLANNED MAINT",
                "MEETING",
                "NO PROGRAM",
                "LOCKED",
                "NO eMONITORING"
            };

            return Ok(commands);
        }

        [HttpPost]
        public async Task<IActionResult> StatusChange([FromBody]StatusChangeDTO statusChangeDTO)
        {            
            if(statusChangeDTO.MachineId == null || String.IsNullOrEmpty(statusChangeDTO.NewStatus)
            || String.IsNullOrEmpty(statusChangeDTO.PartNumber))
            {
                return BadRequest("Not valid a request");
            }  

            return Ok("A machine status has been changed successfully");
        }

    }
}