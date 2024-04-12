using InluppASP_NET1.Filters;
using System.ComponentModel.DataAnnotations;

namespace InluppASP_NET1.Models;

public class SignUpViewModel
{

    [Display(Name ="First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage ="A valid first name is required")]
    [MinLength(2, ErrorMessage = "A valid first name is required")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "A valid last name is required")]
    [MinLength(2, ErrorMessage = "A valid last name is required")]
    [DataType(DataType.Text)]
    public string LastName { get; set;} = null!;


    [Display(Name = "Email", Prompt = "Enter your email")]
    [Required(ErrorMessage = "An valid email address is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "A valid password is required")]
    [MinLength(8, ErrorMessage = "A valid password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm password", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage ="Password don't match")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = null!;


    [CheckboxRequired]

    [Display(Name = "I agree to the Terms & Conditions.")]
    [Required(ErrorMessage = "You must accept the terms and conditions")]
    public bool TermsAndConditions{ get; set; }

}
