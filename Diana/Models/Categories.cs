namespace Diana.Models
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; }
        public List<Products> Products { get; set; }
    }
}
