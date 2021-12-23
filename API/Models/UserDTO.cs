using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserDTO
    {
        public int UserID {get; set;}
        public string Role {get; set;}
        public string UserName {get; set;}
    }
}
