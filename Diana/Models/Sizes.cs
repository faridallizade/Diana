namespace Diana.Models
{
    public class Sizes : BaseEntity
    {
        public string SizeName { get; set; }
        public List<ProductSize> productSizes { get; set; }
    }
}
