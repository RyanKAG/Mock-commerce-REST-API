using AutoMapper;
using personalAPI.DTO;
using personalAPI.DTO.AlbumDto;
using personalAPI.Models;

namespace personalAPI.Profiles
{
    public class AlbumDto : Profile
    {
        public AlbumDto() 
        {
            CreateMap<Album, AlbumReadDto>();
            CreateMap<AlbumCreateDto, Album>();
            
        }
    }
}