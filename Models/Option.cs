namespace personalAPI.Models
{
    public class Option : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; }

    }
}