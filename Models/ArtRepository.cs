using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.Models
{
    public interface ArtRepository
    {
        IEnumerable<Art> GetAllArts();
        Art GetArtById(int ArtId);

    }
}
