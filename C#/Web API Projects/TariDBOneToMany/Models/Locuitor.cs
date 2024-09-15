using System.ComponentModel.DataAnnotations;

namespace TariDBOneToMany.Models
{
    public class Locuitor
    {
        [Key]
        public int LocuitorID { get; set; }

        [MinLength(3), MaxLength(50)]
        public string NumeLocuitor { get; set; } = null!;

        public int? VarstaLocuitor { get; set; }

        [Required]
        public int TaraId { get; set; }

        public Tara? Tara { get; set; }
    }
}
