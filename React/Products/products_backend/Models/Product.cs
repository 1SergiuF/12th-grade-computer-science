using System.ComponentModel.DataAnnotations;

namespace products_backend.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [MaxLength(100)]
        public string ProductName { get; set; } = null!;

        public int Price { get; set; }

        public int Stock { get; set; }

        public ICollection<Order>? Orders { get; set; } 
    }
}
