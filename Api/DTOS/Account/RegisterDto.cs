using System.ComponentModel.DataAnnotations;

namespace Api.DTOS.Account
{
    public class RegisterDto
    {
        [Required]
        [StringLength(15,MinimumLength =3,ErrorMessage ="FirstName must be at list{2}, and maximum {1} characters")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "FirstName must be at list{2}, and maximum {1} characters")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage ="in valid email adderss")]
        public string Email { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Password must be at list{2}, and maximum {1} characters")]
        public string Password { get; set; }
    }
}
