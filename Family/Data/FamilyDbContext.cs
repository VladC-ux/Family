using Family.Data.Enities;
using Microsoft.EntityFrameworkCore;

namespace Family.Data
{
    public class FamilyDbContext:DbContext
    {
        public FamilyDbContext(DbContextOptions<FamilyDbContext> options) : base(options)
        {

            
        }
        public DbSet<Familyy> Families { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
