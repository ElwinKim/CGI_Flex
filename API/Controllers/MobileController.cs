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

            MachinesDTO machine = new MachinesDTO
            {
                MachineId = 1,
                MachineLabel = "MCH01",
                MachineName = "FANUC-SIM",
                Status = "SETUP",
                SetupTime = "30",
                PartNr = "PartNr",
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
                CycleOnTime = 0,
                CycleOffTime = 0,
                OthersTime = 0
            };

            machines.Add(machine);

            return Ok(machines);
        }

        [HttpGet("{MachineId}")]
        public async Task<IActionResult> Machine(int? MachineId)
        {
            if(MachineId == null)
            {
                return BadRequest("You must enter Machine Id");
            }

            GetAMachineDTO machine = new GetAMachineDTO
            {
                MachineId = 1,
                EnetMachineId = 1,
                MachineName = "FANUC-SIM",
                EnetMachineName = "FANUC-SIM",
                Status = "SETUP",
                PartNr = "PartNr",
                Operation = "Operation",
                Operator = "Operator",
                FeedrateOvr = 0,
                SpindleOvr = 0,
                RapidOvr = 0,
                LastEventDateTime = "2021-09-15T22:00:00",
                Shift = 0,
                ShiftStart = "0001-01-01T00:00:00",
                TotalCycleTime = 47132,
                TotalCycleOnTime = 0,
                TotalCycleOffTime = 0,
                TotalSetupTime = 47132,
                OthersTime = 0

            };

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