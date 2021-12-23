using System;

namespace Models
{
    public class AuthenticationResponseDTO
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public string ExpiresIn {get; set;}
        public UserDTO UserDTO { get; set; }
    }
}
