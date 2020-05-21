using AutoMapper;
using LibModelsContext.DataDB;
using LibModelsContext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CV_System_API_New.Controllers.GenericController
{
    [ApiController]
    public abstract class BasicController<TEntity, TDTO> : Controller
        where TEntity : class
        where TDTO : class
    {
        public UserManager<LoginData> UserManager { get; }
        public SignInManager<LoginData> SignInManager { get; }
        public CVSystemContext Context { get; }
        public IMapper MapperAuto { get; }
        public BasicController(UserManager<LoginData> userManager, SignInManager<LoginData> signInManager, CVSystemContext context, IMapper mapper)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            Context = context;
            MapperAuto = mapper;
        }
        [HttpGet("get")]
        public async Task<IActionResult> GetAll()
        {
            using (Context)
            {
                var entities = await Context.Set<TEntity>().ToArrayAsync();
                var dtos = MapperAuto.Map<IEnumerable<TEntity>, IEnumerable<TDTO>>(entities);
                return Ok(dtos);
            }
        }
    }
}
