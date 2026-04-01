using Microsoft.EntityFrameworkCore;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Character> Characters => Set<Character>();
    }
}
