namespace Diana.Models
{
    public class ProductColors : BaseEntity
    {
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int ColorId { get; set; }
        public Colors Colors { get; set; }
    }
}
