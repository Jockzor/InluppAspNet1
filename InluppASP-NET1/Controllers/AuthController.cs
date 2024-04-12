using Infrastructure.Entities;
using InluppASP_NET1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InluppASP_NET1.Controllers;

public class AuthController(UserManager<UserEntity> userManager) : Controller
{
    private readonly UserManager<UserEntity> _userManager = userManager;

    #region SignIn
    [Route("/login")]
    [HttpGet]
    public IActionResult SignIn()
    {
        return View();
    }

    [Route("/login")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)
    {
        if (ModelState.IsValid)
        {

        }
        return View(viewModel);
    }
    #endregion

    #region SignUp
    [Route("/register")]
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }
    #endregion

    [Route("/register")]
    [HttpPost]
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if(!await _userManager.Users.AnyAsync(x=> x.Email == viewModel.Email))
            {
                var userEntity = new UserEntity
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email,
                    UserName = viewModel.Email
                };

                var result = await _userManager.CreateAsync(userEntity, viewModel.Password);
            }
            else
            {
                ViewData["StatusMessage"] = "User with the same email address already exists.";
            }
        }
        return View(viewModel);
    }
}
