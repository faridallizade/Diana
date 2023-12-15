namespace Diana.Models
{
    public class ProductMaterial : BaseEntity
    {
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }          
    }
}
