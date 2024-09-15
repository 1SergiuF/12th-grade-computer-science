using System.ComponentModel.DataAnnotations;

namespace TariDBOneToMany.Models
{
    public class Tara
    {
        [Key]
        public int TaraID { get; set; }

        [MinLength(1), MaxLength(50)]
        public string TaraNume { get; set; } = null!;

        public ICollection<Locuitor>? Locuitori { get; set; }
    }
}
