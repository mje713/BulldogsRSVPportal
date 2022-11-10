using BulldogsRSVPportal.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BulldogsRSVPportal.Data
{
    public class BulldogsDbContext : DbContext
    {
        public BulldogsDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<RSVP> RSVP { get; set; }
    }
}
