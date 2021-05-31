using AutoMapper;
using personalAPI.DTO.AlbumDto;
using personalAPI.DTO.ArtistDto;
using personalAPI.Models;

namespace personalAPI.Profiles
{
    public class ArtistPrfile : Profile
    {
        public ArtistPrfile() 
        {
            
            CreateMap<ArtistCreateDto, Artist>();

            CreateMap<Artist, ArtistReadDto>();
        }
    }
}