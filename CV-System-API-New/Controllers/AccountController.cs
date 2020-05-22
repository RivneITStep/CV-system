using AutoMapper;
using CV_System_API_New.Controllers.GenericController;
using CV_System_API_New.Helpers;
using LibDTO.DTO;
using LibModelsContext.DataDB;
using LibModelsContext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [HttpPost("register/{loginData}")]
        public async Task<IActionResult> Register([FromBody]LoginDataDTO loginData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var login = new LoginData { Email = loginData.Email, UserName = loginData.Email };
                    var res = await UserManager.CreateAsync(login, loginData.Password);
                    if (res.Succeeded)
                    {
                        var user = new CVSystemUser { LoginData = login };
                        await SaveChanges();
                        return Ok("User has registred");
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
            catch (Exception ex)
            {
                return BadRequest($"An error occured. Error: {ex.Message}");
            }
            
        }
        [HttpPut("update/{oldLogin}/{newLogin}")]
        public async Task<IActionResult> UpdateAccount([FromBody]LoginDataDTO oldLogin, [FromBody]LoginDataDTO newLogin)
        {
            try
            {
                var login = await FindEntity(x => x.Email.Equals(oldLogin.Email));
                var newLog = MapperHelper<LoginData, LoginDataDTO>.MapEntityFromDTO(MapperAuto, newLogin);
                return await Update(login, newLog);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occured. Error: {ex.Message}");
            }
        }
    }
}
