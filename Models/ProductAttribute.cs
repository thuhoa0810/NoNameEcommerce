namespace NoName.Models
{
    public class ProductAttribute
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public string? Value { get; set; }

        public virtual Attribution Attribute { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
