using System.ComponentModel.DataAnnotations;

namespace GenshinDBCodeFirst.Models
{
    public class Character
    {
        [Key]
        public int CharID { get; set; }

        [MinLength(3), MaxLength(30)]
        public string Name { get; set; } = null!;

        [MaxLength(1), MinLength(1)]
        public string Gender { get; set; } = null!;

        [MinLength(3), MaxLength(10)]
        public string? Element { get; set; }
    }
}
