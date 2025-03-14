using DotNet8_API_Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DotNet8_API_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeterHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PeterHero>>> GetAllHeroes()
        {
            var heroes = new List<PeterHero>
            {
                new PeterHero
                {
                    Id = 1,
                    Name = "wiki",
                    FirstName = "ziwei",
                    LastName = "Ren",
                    Place = "Kingston"
                }
            };
            return Ok(heroes);
        }
    }
}
