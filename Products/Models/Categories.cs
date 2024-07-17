using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Products.Models
{
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(25)]
        public string CategoryName { get; set; }

        public string CategoryImage { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
