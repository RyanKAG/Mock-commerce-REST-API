using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace personalAPI.Models
{
    public class Product
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

        public List<Option> MyProperty { get; set; }

    }
}