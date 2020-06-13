using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace LoginRegistration.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2,ErrorMessage = "First Name must contain 2 or more characters!")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2,ErrorMessage = "Last Name must contain 2 or more characters!")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8,ErrorMessage="Password must be 8 characters or longer!")]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password", ErrorMessage="Passwords do not match.")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;




    }
}