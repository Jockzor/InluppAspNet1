using System.ComponentModel.DataAnnotations;

namespace InluppASP_NET1.Models;

public class SignInViewModel
{
    [Display(Name = "Email", Prompt = "Enter your email")]
    [Required(ErrorMessage = "An valid email address is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "A valid password is required")]
    [MinLength(8, ErrorMessage = "A valid password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions.")]
    public bool RememberMe { get; set; }
}
