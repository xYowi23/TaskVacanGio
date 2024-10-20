using Microsoft.EntityFrameworkCore;
using VacanGio.Models;

namespace VacanGio.Context
{
    public class VacanGioContext : DbContext
    {
        public VacanGioContext(DbContextOptions<VacanGioContext> options) : base(options)
        {
        }


        public DbSet<Destinazione> Destinaziones { get; set; }
        public DbSet<Pacchetto> Pacchettos { get; set; }
        public DbSet<Recensione> Recensiones { get; set; }
        public DbSet<Destinazione_Pacchetto> Destinazione_Pacchettos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destinazione_Pacchetto>()
                .HasKey(dp => dp.DestinazionePacchettoId); // chiave primaria

            modelBuilder.Entity<Destinazione_Pacchetto>()
                .HasOne(dp => dp.Dest)
                .WithMany(d => d.DesPac) // Destinazione collegamento con  DesPac di tipo ICollection<Destinazione_Pacchetto>
                .HasForeignKey(dp => dp.DestinazioneRiff); // foreign key 

            modelBuilder.Entity<Destinazione_Pacchetto>()
                .HasOne(dp => dp.Pach)
                .WithMany(p => p.DesPac) //  Pacchetto collegamento con DesPac  di tipo ICollection<Destinazione_Pacchetto>
                .HasForeignKey(dp => dp.PacchettoRiff); //foreign key

        }
    }
}
