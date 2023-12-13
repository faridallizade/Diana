namespace Diana.Models
{
    public class ProductColors : BaseEntity
    {
        public List<Products> Products { get; set; }
        public List<Colors> Colors { get; set; }
    }
}
