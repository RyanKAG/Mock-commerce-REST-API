using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : Controller<Artist, ArtistRepo>
    {
        // private readonly IRepo<Album> _repo;

        public ArtistController(ArtistRepo repo) : base(repo)
        {
            
        }


    }
}