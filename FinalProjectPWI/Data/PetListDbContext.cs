using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectPWI.Models;

namespace FinalProjectPWI.Data
{
    public class PetListDbContext : DbContext
    {
        public PetListDbContext (DbContextOptions<PetListDbContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectPWI.Models.PetList> PetList { get; set; } = default!;
    }
}
