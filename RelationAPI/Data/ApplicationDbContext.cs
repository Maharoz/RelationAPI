using MagicVilla_VillaAPI.Models;
using MasjidLibraryAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Parent>()
           .HasMany(p => p.Children)
           .WithOne(c => c.Parent)
           .HasForeignKey(c => c.ParentId)
           .IsRequired();
        }
    }
}
