using MandalorianAPI.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MandalorianAPI.Models
{
    public class Mando
    {
        public string Clan { get; set; }
        public string Name { get; set; }
        public string Signet { get; set; }
        public string HelmetType { get; set; }
        public string ArmorColorPrimary { get; set; }
        public string ArmorColorSecondary { get; set; }
        public string ArmorSpandexColor { get; set; }
        public SkillSet? SkillSet { get; set; }
        public Ability? Ability { get; set; }
        
        public Weapon? Weapon { get; set; }
        public string HomePlanet { get; set; }
        [ForeignKey("StarShip")]
        public string StarShipId { get; set; }
        public StarShip StarShip { get; set; }
    }
}
