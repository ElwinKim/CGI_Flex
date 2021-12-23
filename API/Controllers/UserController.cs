using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers.interfaces;
using Microsoft.AspNetCore.Authorization;
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

        public UserController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Auth([FromBody] SignInDTO signInDTO)
        {
            if(signInDTO.UserName == null || signInDTO.UserName == "" || 
            signInDTO.Password == null || signInDTO.Password == "")
            {
                return BadRequest(new AuthenticationResponseDTO
                {
                    IsAuthSuccessful = false,
                    ErrorMessage = "Please enter username and password correctly."
                });
            }

            UserDTO user = new UserDTO
                    {
                        UserID= 1,
                        UserName = "admin",
                        Role = "Administrator",
                        
                    };
            
            if(signInDTO.UserName.Equals("Admin") && signInDTO.Password.Equals("admin"))
            {
                DateTime expireTime = DateTime.Now;
                expireTime = expireTime.AddDays(7);
                
                return Ok(new AuthenticationResponseDTO
                {
                    IsAuthSuccessful = true,
                    Token = _tokenService.CreateToken(user),
                    ExpiresIn = expireTime.ToString("HH:mm:ss tt"),
                    UserDTO = user
                });
            }
            else{
                return Unauthorized(new AuthenticationResponseDTO
                {
                    IsAuthSuccessful = false,
                    ErrorMessage = "Invalid Authentication"
                }); 
            }
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile()
        {
            return Ok("Good");
        }
    }
}