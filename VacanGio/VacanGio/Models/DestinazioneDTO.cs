using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacanGio.Models
{
   
    public class DestinazioneDTO
    {
      
        public string? CodDest { get; set; }
        public string? Nom { get; set; }

        public string? Desc {  get; set; }
        
        public string? Pae { get; set; }

        public string? ImgU { get; set; } 

        public List<string>? Pacchetti { get; set; }

    }


    /*idDestinazione INT PRIMARY KEY IDENTITY (1,1),
	codDestinazione VARCHAR(25) UNIQUE NOT NULL,
	nome VARCHAR ( 250 ) NOT NULL,
	descrizione TEXT,
	paese VARCHAR (250),
	imgUrl VARCHAR(250)NOT NULL,*/
}
