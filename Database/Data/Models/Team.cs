using System.ComponentModel.DataAnnotations;

namespace Database.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Budget { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}
