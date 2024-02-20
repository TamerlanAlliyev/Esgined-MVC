using Esigned.Core;
using Esigned.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Contexts
{
    public class EsignedDbContext : DbContext
    {
        public EsignedDbContext(DbContextOptions<EsignedDbContext> options) : base(options)
        {

        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Position> Positions { get; set; }

    }
}
