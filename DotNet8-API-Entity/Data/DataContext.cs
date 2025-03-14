
using DotNet8_API_Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNet8_API_Entity.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { 
        
        
        
        }

        public DbSet<PeterHero> PeterHeroes { get; set; }
    }
}
