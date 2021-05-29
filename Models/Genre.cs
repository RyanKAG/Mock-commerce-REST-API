using System.Collections.Generic;

namespace personalAPI.Models
{
    public class Genre : IModel
    {
        public int Id { get ; set ; }
        public string Name { get; set; }


        public IEnumerable<Album> Albums { get; set; }
    }
}