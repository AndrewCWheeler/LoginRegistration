using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class LogUser
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}