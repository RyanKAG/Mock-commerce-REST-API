using System.Collections.Generic;
using personalAPI.Models;

namespace personalAPI.DTO.ArtistDto
{
    public class ArtistCreateDto
    {
        public string Name { get; set; }

        public string password { get; set; }

        public IEnumerable<Album> Albums { get; set; }
    }
}