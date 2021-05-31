using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using AutoMapper;
namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : BaseController<Album, IAlbumRepo>
    {
        private readonly IAlbumRepo _repo;

        public AlbumController(IAlbumRepo repo, IMapper mapper) : base(repo)
        {
            _repo = repo;
        }


}}