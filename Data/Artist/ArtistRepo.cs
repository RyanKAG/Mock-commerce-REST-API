using System.Linq;
using personalAPI.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace personalAPI.Data
{
    public class ArtistRepo : Repo<Artist>, IArtistRepo
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
            var artists = _context.Artists.AsNoTracking().Include(a => a.Albums).ThenInclude(album => album.Genre).ToList();
            return artists;
        }

    }
}