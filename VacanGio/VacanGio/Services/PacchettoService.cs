using VacanGio.Models;
using VacanGio.Repositories;

namespace VacanGio.Services
{
    public class PacchettoService : IServices<PacchettoDTO>
    {
        private readonly PacchettoRepo _repo;
        private readonly DestinazioneRepo _repoDestinazione;
        public PacchettoService(PacchettoRepo repo, DestinazioneRepo repoDestinazione)
        {

            _repo = repo;
            _repoDestinazione = repoDestinazione;
        }

            

        public bool Aggiorna(PacchettoDTO entity)
        {
            throw new NotImplementedException();
        }

        public PacchettoDTO? CercaPerCodice(string codice)
        {
            PacchettoDTO? risultato = null;
            Pacchetto? pachet = _repo.GetByCodr(codice);

            if (pachet is not null)
            {

                List<string> nomeDestinazioni = new List<string>();
                if (pachet.DesPac is not null)
                {
                    foreach (Destinazione_Pacchetto pach in pachet.DesPac)
                    {
                        if (pach.Dest is not null)
                        {
                            nomeDestinazioni.Add(pach.Dest.Nome);
                        }

                    }
                }
                risultato = new PacchettoDTO()
                {
                    CodPac = pachet.CodPacchetto,
                    Nom = pachet.Nome,
                    Pre = pachet.Prezzo,
                    Dur = pachet.Durata,
                    DataIn = pachet.DataInizio,
                    DataFi = pachet.DataFine,
                    Destinazioni = nomeDestinazioni,


                };


            }

            return risultato;
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
            List<Destinazione_Pacchetto> listapachettidestin = new List<Destinazione_Pacchetto>();
            if (entity.Nom is null) 
                return false;

            Pacchetto pac = new Pacchetto()
            {
                CodPacchetto = entity.CodPac is not null ? entity.CodPac : Guid.NewGuid().ToString().ToUpper(),
                Nome=entity.Nom,
                Prezzo=entity.Pre,
                Durata=entity.Dur,
                DataInizio=entity.DataIn,
                DataFine=entity.DataFi,
            };


            if(entity.Destinazioni is not null && entity.Destinazioni.Count>0)

            foreach (string codice in entity.Destinazioni)
            {
                Destinazione? destinazione = _repoDestinazione.GetByCodice(codice);
                Destinazione_Pacchetto relazioneDestinazionePacch = new Destinazione_Pacchetto();
                relazioneDestinazionePacch.Pach = pac;
                relazioneDestinazionePacch.Dest = destinazione;
                listapachettidestin.Add(relazioneDestinazionePacch);
                
            }
            pac.DesPac = listapachettidestin;
            


            return _repo.Create(pac);
        }


    }
}
