using System.ComponentModel.DataAnnotations;

namespace personalAPI.DTO.AlbumDto
{
    public class AlbumCreateDto
    {
        public double Price { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}