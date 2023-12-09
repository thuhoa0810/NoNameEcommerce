using System.ComponentModel.DataAnnotations;

namespace NoName.Models
{
    public class Menu
    {
        public Menu()
        {
            Articles = new HashSet<Article>();
            InverseParentMenuNavigation = new HashSet<Menu>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        [Display(Name = "Menu cha")]
        public int? ParentMenu { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên menu")]
        [Display(Name = "Tên")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Vui lòng nhập alias của menu")]
        [Display(Name = "Alias")]
        public string Alias { get; set; } = null!;
        public int? Index { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập loại menu")]
        public string? Type { get; set; }

        public virtual Menu? ParentMenuNavigation { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Menu> InverseParentMenuNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
