using System.Collections.Generic;

namespace personalAPI.Models
{
    public class Label : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Album> Albums { get; set; }
    }
}