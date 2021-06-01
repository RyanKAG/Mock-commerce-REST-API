using personalAPI.Models;

namespace personalAPI.Data
{
    public interface IArtistRepo : IRepo<Artist>
    {
        Artist GetByName(string name);
    }
}