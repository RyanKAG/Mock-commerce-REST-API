using personalAPI.Models;

namespace personalAPI.Data
{
    public class ProductRepo : Repo<Product, Context>
    {
        public ProductRepo(Context context) : base(context)
        {
            
        }

        
    }
}