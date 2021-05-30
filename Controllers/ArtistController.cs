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
using System;
using Microsoft.AspNetCore.Authorization;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : Controller<Artist, ArtistRepo>
    {
        private readonly ArtistRepo _repo;

        public ArtistController(ArtistRepo repo) : base(repo)
        {
            _repo = repo;
        }


        [HttpPost("login")]
        public IActionResult Login(LoginDTO credintials)
        {

            var artist = _repo.GetByName(credintials.Name);
            bool isValid = BCrypt.Net.BCrypt.Verify(credintials.password, artist.password);
            System.Console.WriteLine(isValid);

            if (isValid)
            {
                var secKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretKey1234567891"));
                var signature = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256);

                var tokenOpts = new JwtSecurityToken(
                claims: new List<Claim>() { new Claim("Id", artist.Id.ToString()) },
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signature
            );
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOpts);
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

    
    }
}