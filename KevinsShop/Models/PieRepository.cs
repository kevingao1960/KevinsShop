using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KevinsShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int PieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == PieId);
        }
    }
}
