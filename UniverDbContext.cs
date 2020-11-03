using Microsoft.EntityFrameworkCore;
using Univer.Models;

namespace Univer
{
    public class UniverDbContext : DbContext
    {
        public UniverDbContext(DbContextOptions<UniverDbContext> options) : base(options)
        {

        }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Disciplines> Disciplines { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
