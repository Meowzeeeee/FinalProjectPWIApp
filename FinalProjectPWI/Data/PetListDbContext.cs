using Microsoft.EntityFrameworkCore;

namespace FinalProjectPWI.Data
{
    public class PetListDbContext : DbContext
    {
        public PetListDbContext(DbContextOptions<PetListDbContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectPWI.Models.PetList> PetList { get; set; } = default!;
    }
}
