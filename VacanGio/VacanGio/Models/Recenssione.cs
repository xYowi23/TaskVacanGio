using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
    
    public class Recenssione
    {
        [Key]
        public int IdRecensione { get; set; }
        public string CodRecensione { get; set; } = null!;

        public string NomeUtente { get; set; } = null!;

        public int Voto { get; set; }

        public string? Commeto { get; set; }
        public DateOnly? DataRecensione { get; set; }

        public int PacchettoRiff { get; set; }
        public Pacchetto? Pach { get; set; }



    }
    /*	idRecensione INT PRIMARY KEY IDENTITY(1,1),
	codRecensione VARCHAR (25)NOT NULL,
	nomeUtente VARCHAR (250) NOT NULL,
	voto INT CHECK (voto BETWEEN 1 AND 5),
	commento TEXT,
	dataRecensione DATE,
	pacchettoRiff INT NOT NULL,*/
}
