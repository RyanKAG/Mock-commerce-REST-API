using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : Controller<Album, AlbumRepo>
    {
        // private readonly IRepo<Album> _repo;

        public GenreController(AlbumRepo repo) : base(repo)
        {
            
        }


    }
}