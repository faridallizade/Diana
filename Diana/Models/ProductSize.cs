namespace Diana.Models
{
    public class ProductSize : BaseEntity
    {
        public List<Sizes> Sizes { get; set; }
        public List<Products> Products { get; set; }
    }
}
