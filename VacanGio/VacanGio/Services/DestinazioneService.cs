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

            IEnumerable<Destinazione> elencodestinazioni = _repo.GetAll();
            foreach (Destinazione destinazione in elencodestinazioni)
            {
                DestinazioneDTO temp = new DestinazioneDTO()
                {
                    CodDest = destinazione.CodDestinazione,
                    Nom = destinazione.Nome,
                    Desc = destinazione.Descrizione,
                    Pae = destinazione.Paese,
                    ImgU = destinazione.ImgUrl,
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
            throw new NotImplementedException();
        }
    }
}
