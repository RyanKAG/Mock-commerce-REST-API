using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace personalAPI.Models
{
    public class Album : IModel
    {
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        
        [Required]
        [MinLength(4)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public  List<Artist> Artists { get; set; }

        public Genre Genre {get; set;}

    }
}