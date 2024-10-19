using Microsoft.EntityFrameworkCore;
using VacanGio.Context;
using VacanGio.Models;

namespace VacanGio.Repositories
{
    public class PacchettoRepo : IRepoLettura<Pacchetto>, IRepoScrittura<Pacchetto>
    {
        private VacanGioContext _context;

        public PacchettoRepo(VacanGioContext context)
        {
            _context = context;
        }

        public bool Create(Pacchetto entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pacchetto> GetAll()
        {
            return _context.Pacchettos.Include(p=>p.DesPac)
                    .ThenInclude(dp=>dp.Dest)
                
                 .ToList();
        }

        public Pacchetto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pacchetto entity)
        {
            throw new NotImplementedException();
        }
    }
}
