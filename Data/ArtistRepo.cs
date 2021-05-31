using System.Linq;
using personalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using personalAPI.Helper.Auth;
using BCrypt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Generic;
using System.Security.Claims;
using System;
using Microsoft.EntityFrameworkCore;

namespace personalAPI.Data
{
    public class ArtistRepo : Repo<Artist, Context>
    {
        private readonly Context _context;
        public ArtistRepo(Context context) : base(context)
        {
            _context = context;
        }

        public Artist GetByName(string name)
        {
            return _context.Artists.FirstOrDefault(p => p.Name == name);
        }

        public override IEnumerable<Artist> GetAll(){
            var artists = _context.Artists.AsNoTracking().Include(a => a.Albums).ToList();
            return artists;
        }

    }
}