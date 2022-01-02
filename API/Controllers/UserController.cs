using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Controllers.interfaces;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(ITokenService tokenService, IHttpContextAccessor httpContextAccessor)
        {
            _tokenService = tokenService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Auth([FromBody] SignInDTO signInDTO)
        {
            if(signInDTO.UserName == null || signInDTO.UserName == "" || 
            signInDTO.Password == null || signInDTO.Password == "")
            {
                return BadRequest();
            }

            AuthenticationDTO authentication = new AuthenticationDTO
                    {
                        UserID= 1,
                        UserName = "Admin",
                        Role = "Administrator",
                        
                    };
            
            if(signInDTO.UserName.Equals("Admin") && signInDTO.Password.Equals("admin"))
            {
                DateTime expireTime = DateTime.Now;
                expireTime = expireTime.AddDays(7);
                
                return Ok(new AuthenticationResponseDTO
                {

                    Token = _tokenService.CreateToken(authentication),
                    ExpiresIn = expireTime.ToString("HH:mm:ss tt"),
                    UserID = authentication.UserID,
                    UserName = authentication.UserName
                });
            }
            else{
                return Unauthorized(); 
            }
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile()
        {
            var userId = HttpContext.User?.Claims?.FirstOrDefault(x=>x.Type == ClaimTypes.NameIdentifier)?.Value;
            if(String.IsNullOrEmpty(userId))
            {
                return BadRequest("Token is not valid");
            }
            int id = int.Parse(userId);

            UserDTO user = new UserDTO
            {
                UserID=id,
                UserName = "username",
                FirstName = "Firstname",
                LastName = "LastName",
                Email = "Email",
                Role = "Role"
            };

            return Ok(user);
        }

        [HttpGet("{message}")]
        [AllowAnonymous]
        public async Task<IActionResult> Health(String message)
        {            
            return Ok(message);
        }

        [HttpGet("{message}")]
        public async Task<IActionResult> UserUiSetUp(string message)
        {
            List<UserUISettingDTO> userUISettings = new List<UserUISettingDTO>();

            UserUISettingDTO uISetting = new UserUISettingDTO
            {
                ShowMachineLabel = 1,
                ShowMachineName = 1,
                CONStatusColor = "00E600",
                COFFStatusColor = "FF2600",
                SetupStatusColor = "0433FF",
                OtherStatusColor = "FF9300",
                ShowPartCount = 1,
                ShowOperator = 1

            };

            userUISettings.Add(uISetting);

            return Ok(userUISettings);
        }
    }
}