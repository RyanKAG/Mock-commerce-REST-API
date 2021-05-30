using System.ComponentModel.DataAnnotations;

namespace personalAPI.Helper.Auth
{
    public class LoginDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string password {get;set;}
    }
}