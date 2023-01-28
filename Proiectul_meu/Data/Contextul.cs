
using Microsoft.EntityFrameworkCore;
using Proiectul_meu.Models;

namespace Proiectul_meu.Data
{
    public class Contextul : DbContext
    {
        public DbSet<Tricou> Tricouri { get; set; }
        public DbSet<Bluza> Bluze { get; set; }
        public DbSet<Incaltaminte> Incaltari{ get; set; }
        public DbSet<Trening> Treninguri { get; set; }
        public DbSet<Pantaloni> Pantaloni { get; set; }
        public DbSet<Sosete> Sosete { get; set; }
        public DbSet<TricouLaTrening> TricouriLaTrening { get; set; }
 
         

        
        public Contextul(DbContextOptions<Contextul> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TricouLaTrening>()
                .HasKey(t => new { t.TreningID, t.TricouID });
            modelBuilder.Entity<Tricou>()

                .HasMany(t => t.TricouLaTreninguri)
                .WithOne(t => t.Tricou)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<TricouLaTrening>()
                .HasOne(t => t.Tricou)
                .WithMany(t => t.TricouLaTreninguri)
                .HasForeignKey(t => t.TricouID);
            modelBuilder.Entity<TricouLaTrening>()
                .HasOne(t => t.Trening)
                .WithMany(t => t.Tricouri)
                .HasForeignKey(t => t.TreningID);
            modelBuilder.Entity<Trening>()
                .HasOne(t => t.Bluza);
            modelBuilder.Entity<Trening>()
                .HasOne(t => t.Pantaloni);
            modelBuilder.Entity<Trening>()
                .HasMany(t => t.Sosete);
            modelBuilder.Entity<Trening>()
                .HasMany(t => t.Tricouri);
            modelBuilder.Entity<Sosete>()
                .HasOne(t => t.Trening);
            base.OnModelCreating(modelBuilder);
        }
    }
}