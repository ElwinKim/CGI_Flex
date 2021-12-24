using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AuthenticationDTO
    {
        public int UserID {get; set;}
        public string Role {get; set;}
        public string UserName {get; set;}
    }
}
