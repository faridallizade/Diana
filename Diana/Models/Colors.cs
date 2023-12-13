namespace Diana.Models
{
    public class Colors : BaseEntity
    {
        public string ColorName { get; set; }
        public List<ProductColors> ProductColors { get; set; }
    }
}
