using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
    [Table("Destinazione_Pacchetto")]
    public class Destinazione_Pacchetto
    {
        [Key]
        public int DestinazionePacchettoId { get; set; }
        public int DestinazioneRiff { get; set; }
        public  Destinazione? Dest { get; set; }
        public int PacchettoRiff { get; set; }
        public Pacchetto? Pach { get; set; }

    }
}
