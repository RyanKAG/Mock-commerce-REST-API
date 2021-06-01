using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Data;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public abstract class BaseController<TModel, TRepo> : ControllerBase
    where TModel : class , IModel
    where TRepo: IRepo<TModel>
    {
        private readonly TRepo _repo;

        public BaseController(TRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Authorize]
        public virtual ActionResult<IEnumerable<TModel>> GetAll(){
            return Ok(_repo.GetAll());
        }

        [HttpGet("{Id}")]
        [ActionName(nameof(Get))]
        public ActionResult<TModel> Get(int Id){
            var entity = _repo.Get(Id);

            if(entity!=null){
                return Ok(entity);
            }

            return NotFound();
        }
        [HttpPost]
        public ActionResult Add(TModel entity){
            _repo.Add(entity);
            _repo.SaveChanges();
            return CreatedAtAction(nameof(Get), new {Id = entity.Id}, new{});
        } 

        [HttpDelete("{id}")]
        public ActionResult deleteCommand(int id)
        {
            var entity = _repo.Get(id);

            if (entity != null)
            {
                _repo.Delete(entity);
                _repo.SaveChanges();
                return NoContent();
            }

            return NotFound();
        }
    }
}