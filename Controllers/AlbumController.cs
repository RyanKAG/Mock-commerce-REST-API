using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using personalAPI.DTO;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : Controller<Album, AlbumRepo>
    {
        private readonly AlbumRepo _repo;

        public AlbumController(AlbumRepo repo) : base(repo)
        {
            _repo = repo;
        }

    
}}