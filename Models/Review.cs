namespace NoName.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int? Star { get; set; }
        public string? Content { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
    }
}
