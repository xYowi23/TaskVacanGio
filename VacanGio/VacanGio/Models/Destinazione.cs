using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
    [Table("Destinazione")]
    public class Destinazione
    {
        [Key]
        public int IdDestinazione { get; set; }
        public string CodDestinazione { get; set; } = null!;
        public string Nome { get; set; } = null!;

        public string? Descrizione {  get; set; }
        
        public string Paese { get; set; }=null!;

        public string? ImgUrl { get; set; }


        public ICollection<Destinazione_Pacchetto> DesPac { get; set; } = new List<Destinazione_Pacchetto>();

    }

    /*idDestinazione INT PRIMARY KEY IDENTITY (1,1),
	codDestinazione VARCHAR(25) UNIQUE NOT NULL,
	nome VARCHAR ( 250 ) NOT NULL,
	descrizione TEXT,
	paese VARCHAR (250),
	imgUrl VARCHAR(250)NOT NULL,*/
}
