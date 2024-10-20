using System.Collections;
using System.IO;
using VacanGio.Models;
using VacanGio.Repositories;

namespace VacanGio.Services
{
    public class DestinazioneService : IServices<DestinazioneDTO>
    {
        private readonly DestinazioneRepo _repo;
        private readonly PacchettoRepo _repoPachetto;
        public DestinazioneService(DestinazioneRepo repo, PacchettoRepo repoPacchetto)
        {
            _repoPachetto = repoPacchetto;
            _repo = repo;
        }

        public bool Aggiorna(DestinazioneDTO entity)
        {
            throw new NotImplementedException();
        }

        public DestinazioneDTO? CercaPerCodice(string codice)
        {
            DestinazioneDTO? risultato = null;

            Destinazione? desti = _repo.GetByCodice(codice);


            if (desti is not null)
            {
                List<string> nomiPacchetti = new List<string>();
                if (desti.DesPac is not null)
                {

                    foreach (Destinazione_Pacchetto dp in desti.DesPac)
                    {
                        if (dp.Pach is not null)
                        {
                            nomiPacchetti.Add(dp.Pach.Nome);
                        }
                    }
                }
                risultato = new DestinazioneDTO()
                {
                    CodDest = desti.CodDestinazione,
                    Nom = desti.Nome,
                    Desc = desti.Descrizione,
                    Pae = desti.Paese,
                    ImgU = desti.ImgUrl,
                    Pacchetti = nomiPacchetti


                };
            }

            return risultato;
        }

        public IEnumerable<DestinazioneDTO> CercaTutti()
        {
            ICollection<DestinazioneDTO> risultato = new List<DestinazioneDTO>();

            IEnumerable<Destinazione> elencoDestinazioni = _repo.GetAll();
            foreach (Destinazione destinazione in elencoDestinazioni)
            {
                List<string> nomiPacchettti = new List<string>();
                if (destinazione.DesPac is not null)
                    foreach (Destinazione_Pacchetto descPachetto in destinazione.DesPac)
                    {
                        if (descPachetto.Pach is not null)
                            nomiPacchettti.Add(descPachetto.Pach.Nome);


                    }

                DestinazioneDTO temp = new DestinazioneDTO()
                {
                    CodDest = destinazione.CodDestinazione,
                    Nom = destinazione.Nome,
                    Desc = destinazione.Descrizione,
                    Pae = destinazione.Paese,
                    ImgU = destinazione.ImgUrl,
                    Pacchetti = nomiPacchettti,


                };

                risultato.Add(temp);
            }

            return risultato;
        }


        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(DestinazioneDTO entity)
        {
            
         List<Destinazione_Pacchetto> listadesinazionepach = new List<Destinazione_Pacchetto>();
            if (entity.Nom is null || entity.Pae is null)
                return false;
        Destinazione dest = new Destinazione()
        {
            CodDestinazione = entity.CodDest is not null ? entity.CodDest : Guid.NewGuid().ToString().ToUpper(),
            Nome = entity.Nom,
            Descrizione = entity.Desc,
            Paese = entity.Pae,
            ImgUrl = entity.ImgU,

        };
            if (entity.Pacchetti is not null && entity.Pacchetti.Count >0)
            {
                foreach (string codice in entity.Pacchetti)
                {
                    Pacchetto? pacchetto = _repoPachetto.GetByCodr(codice);

                    Destinazione_Pacchetto relaziioneDestPacchetto = new Destinazione_Pacchetto();
                    relaziioneDestPacchetto.Pach = pacchetto;
                    relaziioneDestPacchetto.Dest = dest;
                    listadesinazionepach.Add(relaziioneDestPacchetto);
                }
                dest.DesPac = listadesinazionepach;
            }
            return _repo.Create(dest);
              
        }
    }
}
