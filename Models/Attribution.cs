namespace NoName.Models
{
    public class Attribution
    {
        public Attribution()
        {
            ProductAttributes = new HashSet<ProductAttribute>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
