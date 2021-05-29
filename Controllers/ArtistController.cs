using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : Controller<Album, AlbumRepo>
    {
        // private readonly IRepo<Album> _repo;

        public ArtistController(AlbumRepo repo) : base(repo)
        {
            
        }


    }
}