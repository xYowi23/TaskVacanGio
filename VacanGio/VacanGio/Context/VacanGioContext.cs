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
        public DbSet<Recenssione> Recenssiones { get; set; }
        public DbSet<Destinazione_Pacchetto> Destinazione_Pacchettos { get; set; }
        

    }
}
