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
            throw new NotImplementedException();
        }

        public Recensione? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Recensione entity)
        {
            throw new NotImplementedException();
        }
    }
}
