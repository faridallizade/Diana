namespace Diana.Models
{
    public class Images:BaseEntity
    {
        public string ImgUrl { get; set; }
        public bool? IsActive { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
    }
}
