using System.ComponentModel.DataAnnotations;
using wedding_planner.Models;

namespace wedding_planner.Models
{
    public class RegisterUser : BaseEntity
    {
        [Display(Name = "First Name")]
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }


        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Password")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation must match")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

    }

    public class LoginUser: BaseEntity
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email not found")]
        public string LogEmail { get; set;}


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LogPassword { get; set;}
    }
}