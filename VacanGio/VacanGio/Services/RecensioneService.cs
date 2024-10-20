using VacanGio.Models;
using VacanGio.Repositories;

namespace VacanGio.Services
{
    public class RecensioneService : IServices<RecensioneDTO>
    {
        private readonly RecensioneRepo _repo;
        private readonly PacchettoService _pacchettoService;

        public RecensioneService(RecensioneRepo repo, PacchettoService pacchettoService) 
        {
            _pacchettoService = pacchettoService;
            _repo = repo;
        }



        public bool Aggiorna(RecensioneDTO entity)
        {
            throw new NotImplementedException();
        }

        public RecensioneDTO? CercaPerCodice(string codice)
        {
           RecensioneDTO? risultato = null;
            Recensione? recen =_repo.GetByCodice(codice);
            if (recen != null) {
                PacchettoDTO? pacchetto = _pacchettoService.CercaPerId(recen.PacchettoRiff);
                risultato = new RecensioneDTO()
                {
                    CodRec = recen.CodRecensione,
                    NomeUt = recen.NomeUtente,
                    Vot = recen.Voto,
                    Com = recen.Commento,
                    DataRe = recen.DataRecensione,
                    Pach = pacchetto != null ? pacchetto.Nom : "",
                };
            
            }
            return risultato;
        }

        public IEnumerable<RecensioneDTO> CercaTutti()
        {
            ICollection<RecensioneDTO> risultato= new List<RecensioneDTO>();
            IEnumerable<Recensione> recensionelista = _repo.GetAll();
            foreach (Recensione recensione in recensionelista)
            {
                PacchettoDTO? pacchetto = _pacchettoService.CercaPerId(recensione.PacchettoRiff);
                RecensioneDTO temp = new RecensioneDTO()
                    {
                        CodRec = recensione.CodRecensione,
                        NomeUt = recensione.NomeUtente,
                        Vot = recensione.Voto,
                        Com = recensione.Commento,
                        DataRe = recensione.DataRecensione,
                        Pach = pacchetto != null ? pacchetto.Nom:"",
                    };
                    risultato.Add(temp);

                
            }

            return risultato;
        }

        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(RecensioneDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
