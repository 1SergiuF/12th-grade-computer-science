using System.ComponentModel.DataAnnotations;

namespace ScoalaCodeFirst.Models
{
    public class Elev
    {
        [Key]
        public int ElevID { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Nume { get; set; } = "";

        [MinLength(2)]
        public string Clasa { get; set; } = null!;
    }
}
