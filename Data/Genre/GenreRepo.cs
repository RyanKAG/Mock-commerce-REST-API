using personalAPI.Models;

namespace personalAPI.Data
{
    public class GenreRepo : Repo<Genre>, IGenreRepo
    {
        private readonly Context _context;

        public GenreRepo(Context context) : base(context)
        {
            _context = context;
        }
    }
}