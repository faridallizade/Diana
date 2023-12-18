using Diana.Models;

namespace Diana.Areas.Admin.ViewModels
{
    public class ProductVm
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string? Description { get; set; }
        public Categories Category { get; set; }
        public List<Images> ProductImages { get; set; }
        public List<ProductSize>? productSizes { get; set; }
        public List<ProductColors>? ProductColors { get; set; }
        public List<ProductMaterial>? ProductMaterials { get; set; }
    }
}
