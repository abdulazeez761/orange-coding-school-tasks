using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        public string ProductImage { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        public int ProductCategoryID { get; set; }

        [ForeignKey("ProductCategoryID")]
        public Categories Category { get; set; }
    }
}

