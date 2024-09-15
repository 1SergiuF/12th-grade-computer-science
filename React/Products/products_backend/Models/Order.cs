using System.ComponentModel.DataAnnotations;

namespace products_backend.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [MaxLength(50)]
        public string ConsigneeName { get; set; } = null!;

        [Required]
        public DateTime OrderDate { get; set; }

        public int ProductID { get; set; }

        public Product? Product { get; set; }
    }
}
