using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : Controller<Album, AlbumRepo>
    {
        private readonly IRepo<Album> _repo;

        public AlbumController(AlbumRepo repo) : base(repo)
        {
            _repo = repo;
        }


        [HttpGet]
        [Authorize]
        public override ActionResult<IEnumerable<Album>> GetAll(){
            return Ok(new {test ='f'});
        }

    }
}