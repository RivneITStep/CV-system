using LibDTO.DTO;
using LibModelsContext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_System_API_New.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<LoginData> UserManager { get; }
        public SignInManager<LoginData> SignInManager { get; }
        public AccountController(UserManager<LoginData> userManager, SignInManager<LoginData> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(LoginDataDTO loginData)
        {
            if (ModelState.IsValid)
            {
                var login = new LoginData { Email = loginData.Email, UserName = loginData.Email };
                var res = await UserManager.CreateAsync(login, loginData.Password);
                if (res.Succeeded)
                {
                    var user = new CVSystemUser { LoginData = login };
                    await SignInManager.SignInAsync(user.LoginData, false);
                    return Ok();
                }
                else
                {
                    foreach (var error in res.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return BadRequest(ModelState);
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
