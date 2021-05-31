using System.Collections.Generic;
using personalAPI.Models;

namespace personalAPI.DTO.ArtistDto
{
    public class ArtistReadDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string password { get; set; }

        public IEnumerable<Album> Albums { get; set; }
    }
}