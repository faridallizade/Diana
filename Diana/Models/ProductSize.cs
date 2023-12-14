namespace Diana.Models
{
    public class ProductSize : BaseEntity
    {
        public int SizeId { get; set; }
        public Sizes Sizes { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
    }
}
