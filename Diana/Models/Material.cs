namespace Diana.Models
{
    public class Material : BaseEntity
    {
        public string MaterialName { get; set; }
        public List<ProductMaterial> ProductMaterials { get; set; }
    }
}
