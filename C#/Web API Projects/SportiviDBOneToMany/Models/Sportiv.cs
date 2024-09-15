using System.ComponentModel.DataAnnotations;

namespace SportiviDBOneToMany.Models
{
    public class Sportiv
    {
        [Key]
        public int SportivID { get; set; }

        [MinLength(3), MaxLength(50)]
        public string Nume { get; set; } = null!;

        public int SportId { get; set; }

        public Sport? Sport { get; set; }
    }
}
