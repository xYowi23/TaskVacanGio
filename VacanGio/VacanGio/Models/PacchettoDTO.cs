using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
   
    public class PacchettoDTO
    {

        public string? CodPac { get; set; }
        public string Nom { get; set; } = null!;

        public decimal Pre { get; set; }

        public int Dur { get; set; } = 0;

        public DateOnly? DataIn{ get; set; }
        public DateOnly? DataFi { get; set; }

        public List<string>? Destinazioni { get; set; }

        public List<string>? Recensioni { get; set; }
    }

    /*idPacchetto INT PRIMARY KEY IDENTITY(1,1),
	codPacchetto VARCHAR (25) NOT NULL,
	nome VARCHAR ( 250 ) NOT NULL,
	prezzo DECIMAL (8,2) NOT NULL CHECK (prezzo >0),
	durata INT DEFAULT 0,
	dataInizio DATE,
	dataFine DATE,*/
}
