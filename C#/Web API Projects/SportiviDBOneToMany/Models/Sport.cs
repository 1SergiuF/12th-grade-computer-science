using System.ComponentModel.DataAnnotations;

namespace SportiviDBOneToMany.Models
{
    public class Sport
    {
        [Key]
        public int SportID { get; set; }

        [MinLength(3), MaxLength(50)]
        public string SportNume { get; set; } = null!;

        public ICollection<Sportiv>? Sportivi { get; set; }
    }
}
