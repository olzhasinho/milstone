using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.Models
{
    public class ARepository: ArtRepository
    {
        private readonly AppDbContext _appDbContext;

        public ARepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Art> GetAllArts()
        {
            return _appDbContext.Arts;

        }

        public Art GetArtById(int ArtId)
        {
            return _appDbContext.Arts.FirstOrDefault(a => a.Id == ArtId);
        }
    }
}
