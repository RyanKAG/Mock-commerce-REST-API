using personalAPI.Models;

namespace personalAPI.Data
{
    public class AlbumRepo : Repo<Album, Context>
    {
        public AlbumRepo(Context context) : base(context)
        {
            
        }

        
    }
}