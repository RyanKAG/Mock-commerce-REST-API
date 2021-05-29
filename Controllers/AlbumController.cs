using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : Controller<Album, AlbumRepo>
    {
        // private readonly IRepo<Album> _repo;

        public AlbumController(AlbumRepo repo) : base(repo)
        {
            
        }


    }
}