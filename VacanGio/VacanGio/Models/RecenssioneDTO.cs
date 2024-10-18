using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
    
    public class RecenssioneDTO
    {
        public string CodRec { get; set; } = null!;

        public string NomeUt { get; set; } = null!;

        public int Vot { get; set; }

        public string? Com { get; set; }
        public DateOnly? DataRe{ get; set; }

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
