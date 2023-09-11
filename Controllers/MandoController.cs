using MandalorianAPI.Models;
using MandalorianAPI.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MandalorianAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MandoController : ControllerBase
    {
        private readonly ILogger<MandoController> _logger;

        public MandoController(ILogger<MandoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMando")]
        public IActionResult Index()
        //public async Task<IActionResult> Index()
        {

            var moldyCrow = new StarShip
            {
                Id = "MC1",
                Type = "Mandalorian Dropship",
                HyperDriverCapable = true,
                Name = "The Moldy Crow",
                Ability = Ability.Cloaking,
            };

            var BoKatanKryze = new Mando
            {
                Clan = "Kryze",
                Name = "Bo-Katan",
                Signet = "Night Owls",
                HelmetType = "Slim",
                ArmorColorPrimary = "Blue",
                ArmorColorSecondary = "Teal",
                ArmorSpandexColor = "Tan",
                SkillSet = SkillSet.Pilot,
                Weapon = Weapon.Blaster,
                HomePlanet = "Mandalore",
                StarShipId = "MC1",
                StarShip = moldyCrow,
            };

            // var objReturning = JsonConvert.SerializeObject(BoKatanKryze);

            return Ok(JsonConvert.SerializeObject(BoKatanKryze));
        }
    }
}