using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;
using System.Security.Permissions;

namespace Diana.Models
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public List<Images> ProductImages { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public List<ProductSize> productSizes { get; set; }
        public List<ProductColors> ProductColors { get; set; }
        public List<ProductMaterial> ProductMaterials { get; set; }
    }
}
