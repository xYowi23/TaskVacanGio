using System.Collections;
using VacanGio.Models;
using VacanGio.Repositories;

namespace VacanGio.Services
{
    public class DestinazioneService : IServices<DestinazioneDTO>
    {
        private readonly DestinazioneRepo _repo;
        public DestinazioneService(DestinazioneRepo repo)
        {

            _repo = repo;
        }

        public bool Aggiorna(DestinazioneDTO entity)
        {
            throw new NotImplementedException();
        }

        public DestinazioneDTO? CercaPerCodice(string codice)
        {
            throw new NotImplementedException();
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
           if(entity.Nom is null || entity.Pae is null)
                return false;
            Destinazione dest = new Destinazione()
            {
                CodDestinazione = entity.CodDest is not null ? entity.CodDest : Guid.NewGuid().ToString().ToUpper(),
                Nome=entity.Nom,
                Descrizione=entity.Desc,
                Paese=entity.Pae,
                ImgUrl=entity.ImgU,

            };
            return _repo.Create(dest);
              
        }
    }
}
