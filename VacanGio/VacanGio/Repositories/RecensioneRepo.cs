using VacanGio.Context;
using VacanGio.Models;

namespace VacanGio.Repositories
{
    public class RecensioneRepo : IRepoLettura<Recensione>, IRepoScrittura<Recensione>
    {
        private VacanGioContext _context;

        public RecensioneRepo(VacanGioContext context)
        {
            _context = context;
        }

        public bool Create(Recensione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recensione> GetAll()
        {
            return _context.Recensiones.ToList();
        }

        public Recensione? GetById(int id)
        {
          return _context.Recensiones.Find(id);
        }

        public bool Update(Recensione entity)
        {
            throw new NotImplementedException();
        }

        public Recensione? GetByCodice(string codice)
        {
            return _context.Recensiones.FirstOrDefault(r => r.CodRecensione == codice);
        }
    }
}
