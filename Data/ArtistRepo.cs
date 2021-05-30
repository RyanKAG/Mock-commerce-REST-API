using personalAPI.Models;

namespace personalAPI.Data
{
    public class ArtistRepo : Repo<Artist, Context>
    {
        public ArtistRepo(Context context) : base(context)
        {
            
        }

        
    }
}