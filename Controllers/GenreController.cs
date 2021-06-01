using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : BaseController<Genre, IGenreRepo>
    {
        private readonly IGenreRepo _repo;

        public GenreController(IGenreRepo repo) : base(repo)
        {
            
        }


    }
}