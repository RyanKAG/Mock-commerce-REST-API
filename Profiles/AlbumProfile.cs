using AutoMapper;
using personalAPI.DTO;
using personalAPI.DTO.ArtistDto;
using personalAPI.Models;

namespace personalAPI.Profiles
{
    public class AlbumDto : Profile
    {
        public AlbumDto() : base()
        {
            CreateMap<Artist, ArtistReadDto>();
        }
    }
}