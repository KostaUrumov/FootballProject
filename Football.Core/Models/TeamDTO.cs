using Database.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Football.Core.Models
{
    public class TeamDTO
    {
        public TeamDTO()
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
