using VacanGio.Models;
using VacanGio.Repositories;

namespace VacanGio.Services
{
    public class PacchettoService : IServices<PacchettoDTO>
    {
        private readonly PacchettoRepo _repo;
        public PacchettoService(PacchettoRepo repo)
        {

            _repo = repo;
        }

            

        public bool Aggiorna(PacchettoDTO entity)
        {
            throw new NotImplementedException();
        }

        public PacchettoDTO? CercaPerCodice(string codice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PacchettoDTO> CercaTutti()
        {
            ICollection<PacchettoDTO> risultato = new List<PacchettoDTO>();


            IEnumerable<Pacchetto> elencoPacchetti = _repo.GetAll();
            foreach (Pacchetto pacchetto in elencoPacchetti)
            {
                List<string> nomiDestinazioni = new List<string>();
                if (pacchetto.DesPac is not null)
                    foreach (Destinazione_Pacchetto desPacchetto in pacchetto.DesPac)
                    {
                        if (desPacchetto.Dest is not null)
                            nomiDestinazioni.Add(desPacchetto.Dest.Nome);
                    }

                PacchettoDTO temp = new PacchettoDTO()
                {
                    CodPac = pacchetto.CodPacchetto,
                    Nom=pacchetto.Nome,
                    Pre=pacchetto.Prezzo,
                    Dur=pacchetto.Durata,
                    DataIn=pacchetto.DataInizio,
                    DataFi=pacchetto.DataFine,
                    Destinazioni= nomiDestinazioni,

                };
                risultato.Add(temp);

            }
            return risultato;
        }

        public bool Elimina(string codice)
        {
            throw new NotImplementedException();
        }

        public bool Inserisci(PacchettoDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
