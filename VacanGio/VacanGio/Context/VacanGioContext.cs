using Microsoft.EntityFrameworkCore;
using VacanGio.Models;

namespace VacanGio.Context
{
    public class VacanGioContext: DbContext
    {
        public VacanGioContext(DbContextOptions<VacanGioContext> options) : base(options)
        {
        }


        public DbSet<Destinazione> Destinaziones { get; set; }
        public DbSet<Pacchetto> Pacchettos { get; set; }
        public DbSet<Recensione> Recenssiones { get; set; }
        public DbSet<Destinazione_Pacchetto> Destinazione_Pacchettos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destinazione_Pacchetto>()
                .HasKey(dp => dp.DestinazionePacchettoId); // Chiave primaria

            modelBuilder.Entity<Destinazione_Pacchetto>()
                .HasOne(dp => dp.Dest)
                .WithMany(d => d.DesPac) // Assicurati che Destinazione abbia una proprietà DesPac di tipo ICollection<Destinazione_Pacchetto>
                .HasForeignKey(dp => dp.DestinazioneRiff); // Chiave esterna

            modelBuilder.Entity<Destinazione_Pacchetto>()
                .HasOne(dp => dp.Pach)
                .WithMany(p => p.DesPac) // Assicurati che Pacchetto abbia una proprietà DestinazionePacchetti di tipo ICollection<Destinazione_Pacchetto>
                .HasForeignKey(dp => dp.PacchettoRiff); // Chiave esterna
        }

    }
}
