using AutoMapper;
using CV_System_API_New.Helpers;
using LibModelsContext.DataDB;
using LibModelsContext.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private string entityName;
        private string dtoName;
        public BasicController(UserManager<LoginData> userManager, SignInManager<LoginData> signInManager, CVSystemContext context, IMapper mapper)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            Context = context;
            MapperAuto = mapper;
            entityName = typeof(TEntity).Name;
            dtoName = typeof(TDTO).Name;
        }
        ~BasicController()
        {
            Context.Dispose();
        }
        [HttpGet("get")]
        public async virtual Task<IActionResult> GetAll()
        {
            try
            {
                var entities = await GetEntitiesAsync();
                var dtos = MapperHelper<TEntity, TDTO>.MapDTOsFromEntities(MapperAuto, entities);
                return GetResult(dtos);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occured. Error: {ex.Message}");
            }
        }
        protected async Task<IActionResult> Update(TEntity oldItem, TEntity newItem)
        {
            try
            {
                if (oldItem == null || newItem == null || !ModelState.IsValid)
                {
                    return BadRequest($"Item of type {dtoName} is null. Or ModelState is invalid");
                }
                else
                {
                    Context.Entry<TEntity>(oldItem).State = EntityState.Detached;
                    oldItem = UpdateEntity(oldItem, newItem);
                    Context.Entry<TEntity>(oldItem).State = EntityState.Modified;
                    await SaveChanges();
                    var newDTO = MapperHelper<TEntity, TDTO>.MapDTOFromEntity(MapperAuto, oldItem);
                    return Ok(newDTO);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occured. Error: {ex.Message}");
            }
        }
        protected async Task<IActionResult> Post(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Add(entity);
                await SaveChanges();
                return Ok("Item added");
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occured. Error: {ex.Message}");
            }
        }
        protected async Task<IActionResult> Remove(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Remove(entity);
                await SaveChanges();
                return Ok("Item removed");
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occured. Error: {ex.Message}");
            }
        }
        private async Task<IEnumerable<TEntity>> GetEntitiesAsync()
        {
            return await Context.Set<TEntity>().ToArrayAsync();
        }
        protected IActionResult GetResult(object obj)
        {
            IActionResult result = null;
            if (obj == null)
            {
                result = BadRequest($"Object of type {dtoName} is null");
            }
            else if (obj is IEnumerable<TDTO> && (obj as IEnumerable<TDTO>).Count().Equals(0))
            {
                result = BadRequest($"Collection of type {dtoName} is empty");
            }
            else
            {
                result = Ok(obj);
            }
            return result;
        }
        private TEntity UpdateEntity(TEntity oldEntity, TEntity newEntity)
        {
            var type = oldEntity.GetType();
            var properties = type.GetProperties();
            object propValue = null;
            var propName = "";
            foreach (var p in properties)
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    propName = properties[i].Name;
                    if (i == 0 && propName.Contains("Id"))
                    {
                        continue;
                    }
                    propValue = type.GetProperty(propName).GetValue(newEntity);
                    properties[i].SetValue(oldEntity, propValue);
                }
            }
            return oldEntity;
        }
        protected async Task<TEntity> FindEntity(Func<TEntity, bool> filter)
        {
            var list = await Context.Set<TEntity>().ToListAsync();
            var entity = list.FirstOrDefault(filter);
            return entity;
        }
        protected async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
