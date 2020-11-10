using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rozdzial2.Models.ModelConfiguration;

namespace Rozdzial2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Bill> Bill { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new BillConfiguration());
            builder.ApplyConfiguration(new InformationsConfiguration());
            base.OnModelCreating(builder);
        }
    }


}
