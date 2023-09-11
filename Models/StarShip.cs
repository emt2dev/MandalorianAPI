using MandalorianAPI.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MandalorianAPI.Models
{
    public class StarShip
    {
        [Key]
        public string Id { get; set; }
        public string Type { get; set; }
        public bool HyperDriverCapable { get; set; }
        public ICollection<Weapon>? Weapons { get; set; }
        public string Name { get; set; }
        public Ability? Ability { get; set; }
    }
}
