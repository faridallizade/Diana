namespace Diana.Models
{
    public class ProductMaterial : BaseEntity
    {
        public List<Material> Materials { get; set; }
        public List<Products> Products { get; set; }
    }
}
