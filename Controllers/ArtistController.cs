using personalAPI.Data;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Models;
using personalAPI.Helper.Auth;
using BCrypt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using personalAPI.DTO.ArtistDto;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : BaseController<Artist, IArtistRepo>
    {
        private readonly IArtistRepo _repo;
        private readonly IMapper _mapper;

        public ArtistController(IArtistRepo repo, IMapper mapper) : base(repo)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpPost("login")]
        public ActionResult Login(LoginDTO credintials)
        {
            var artist = checkUser(credintials.Name, credintials.password);

            if (artist != null)
            {
                var claims = new List<Claim>() {
                    new Claim("Id", artist.Id.ToString())
                    };

                string token = AuthHelper.GenerateJWT(claims);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        [HttpPost("register")]
        public ActionResult Register(Artist artist)
        {
            bool isRegistered = _repo.GetByName(artist.Name) != null;

            if (isRegistered)
                return Conflict();

            artist.password = BCrypt.Net.BCrypt.HashPassword(artist.password);
            _repo.Add(artist);
            _repo.SaveChanges();

            return Ok();
        }

        private Artist checkUser(string name, string password)
        {
            var artist = _repo.GetByName(name);

            if (artist == null)
            {
                return null;
            }

            bool isValid = BCrypt.Net.BCrypt.Verify(password, artist.password);
            
            return isValid ? artist : null;
        }

        
        [HttpGet]
        [Authorize]
        public override ActionResult<IEnumerable<ArtistReadDto>> GetAll(){
            var artists = _repo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ArtistReadDto>>(artists));
        }
    }
}