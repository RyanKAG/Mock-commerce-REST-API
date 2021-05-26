using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;

namespace Controllers
{
    [Route("api/")]
    public class ProductController : ControllerBase
    {
        private readonly IRepo<Product> _repo;

        public ProductController(IRepo<Product> repo)
        {
            _repo = repo;
        }


    }
}