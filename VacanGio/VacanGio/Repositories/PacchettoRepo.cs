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
            bool risultato = false;
            try
            {
                _context.Pacchettos.Add(entity);
                _context.SaveChanges();
                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return risultato;
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

        public Pacchetto? GetByCodr(string codice)
        {
           return  _context.Pacchettos
                        .Include(P=>P.DesPac)
                        .ThenInclude(dp=>dp.Dest)
                        .FirstOrDefault(d => d.CodPacchetto == codice);
        }

    }
}
