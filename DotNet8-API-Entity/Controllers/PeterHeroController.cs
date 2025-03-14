using DotNet8_API_Entity.Data;
using DotNet8_API_Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace DotNet8_API_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeterHeroController : ControllerBase
    {

        // injection SSMS
        private readonly DataContext _context;

        public PeterHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PeterHero>>> GetAllHeroes()
        {
            var heroes = await _context.PeterHeroes.ToListAsync();
            return Ok(heroes);
        }
    }
}
