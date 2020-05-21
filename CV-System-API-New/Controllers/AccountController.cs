using AutoMapper;
using CV_System_API_New.Controllers.GenericController;
using LibDTO.DTO;
using LibModelsContext.DataDB;
using LibModelsContext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CV_System_API_New.Controllers
{
    
    [Route("api/[controller]")]
    public class AccountController : BasicController<LoginData, LoginDataDTO>
    {
        public AccountController(UserManager<LoginData> userManager, SignInManager<LoginData> signInManager, CVSystemContext context, IMapper mapper) :
            base(userManager, signInManager, context, mapper)
        {
        }
        [HttpPost("post")]
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
