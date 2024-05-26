using System.ComponentModel.DataAnnotations;

namespace eventures.Models
{
    public class User
    {
        //primary key
        public int Id { get; set; }
        //public int UserId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\-_.~*]+$", ErrorMessage = "Username can only contain alphanumeric characters, dashes and underscores, dots, asterisks and tildes")]
        public string Username { get; set; }
        /*
         * alphanumeric characters : character (a-z) + number (0-9)
         * dash (gạch ngang) -
         * underscore (gạch chân) _
         * dot (dấu chấm)  .
         * asterisk (dấu sao)  *
         * tilde (dấu ngã) ~
         */

        [Required]
        [MinLength(5, ErrorMessage = "Password must be at least 5 characters")]
        public string Password { get; set; }

        [Required (ErrorMessage = "Email can not be null")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "UCN must be exactly 10 numbers")]  
        //exactly 10 numbers
        public int UCN { get; set; } //Unique Citizen Number
    }
}
