using VacanGio.Context;
using VacanGio.Models;
using Microsoft.EntityFrameworkCore;

namespace VacanGio.Repositories
{
    public class DestinazioneRepo : IRepoLettura<Destinazione>, IRepoScrittura<Destinazione>
    {

        private VacanGioContext _context;

        public DestinazioneRepo(VacanGioContext context)
        {
            _context = context;
        }


        public bool Create(Destinazione entity)
        {
            bool risultato = false;
            try
            {
                _context.Destinaziones.Add(entity);
                _context.SaveChanges();
                risultato = true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
             
            }
            return risultato;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destinazione> GetAll()
        {
            return _context.Destinaziones.Include(d => d.DesPac)
                    .ThenInclude(dp => dp.Pach) 
                   .ToList();
        }

        public Destinazione? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Destinazione entity)
        {
            throw new NotImplementedException();
        }
    }
}
