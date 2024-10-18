using VacanGio.Context;
using VacanGio.Models;

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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Destinazione> GetAll()
        {
            return _context.Destinaziones.ToList();
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
