using Microsoft.EntityFrameworkCore;
using EvolentDemo.Models;

namespace EvolentDemo.Models.Data
{
    public class EvolentContext : DbContext
    {
        public EvolentContext(DbContextOptions<EvolentContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }
    }
}
