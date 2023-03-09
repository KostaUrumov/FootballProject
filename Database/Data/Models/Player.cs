using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Data.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [ForeignKey(nameof(Team))]
        public int TeamID { get; set; }
        public virtual Team Team { get; set; }
    }
}
