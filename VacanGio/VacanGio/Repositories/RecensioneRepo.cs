using VacanGio.Context;
using VacanGio.Models;

namespace VacanGio.Repositories
{
    public class RecensioneRepo : IRepoLettura<Recenssione>, IRepoScrittura<Recenssione>
    {
        private VacanGioContext _context;

        public RecensioneRepo(VacanGioContext context)
        {
            _context = context;
        }

        public bool Create(Recenssione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recenssione> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recenssione? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Recenssione entity)
        {
            throw new NotImplementedException();
        }
    }
}
