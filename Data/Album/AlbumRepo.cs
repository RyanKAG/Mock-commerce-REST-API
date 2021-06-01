using personalAPI.Models;

namespace personalAPI.Data
{
    public class AlbumRepo : Repo<Album> , IAlbumRepo
    {
        public AlbumRepo(Context context) : base(context)
        {
            
        }
    }
}