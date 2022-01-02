using System;

namespace Models
{
    public class AuthenticationResponseDTO
    {
        public string Token { get; set; }
        public string ExpiresIn {get; set;}
        public int UserID {get; set;}
        public string UserName {get; set;}
    }
}
