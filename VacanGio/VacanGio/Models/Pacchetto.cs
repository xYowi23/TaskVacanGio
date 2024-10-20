using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
    [Table("PacchettoVacanza")]
    public class Pacchetto
    {
        [Key]
        public int IdPacchetto { get; set; }
        public string CodPacchetto { get; set; } = null!;
        public string Nome { get; set; } = null!;

        public decimal Prezzo { get; set; }

        public int Durata { get; set; } = 0;

        public DateOnly? DataInizio { get; set; }
        public DateOnly? DataFine { get; set; }

       
        public ICollection<Destinazione_Pacchetto> DesPac { get; set; }= new List<Destinazione_Pacchetto>();
        public ICollection<Recensione> recensoni { get; set; } = new List<Recensione>();
    }

    /*idPacchetto INT PRIMARY KEY IDENTITY(1,1),
	codPacchetto VARCHAR (25) NOT NULL,
	nome VARCHAR ( 250 ) NOT NULL,
	prezzo DECIMAL (8,2) NOT NULL CHECK (prezzo >0),
	durata INT DEFAULT 0,
	dataInizio DATE,
	dataFine DATE,*/
}
