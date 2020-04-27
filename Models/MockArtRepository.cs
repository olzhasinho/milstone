using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.Models
{
    public class MockArtRepository : ArtRepository
    {
        private List<Art> _arts;

        public MockArtRepository()
        {
            if (_arts == null)
            {
                InitializeArts();

            }
        }

        private void InitializeArts ()
        {
            _arts = new List<Art>
            {
                new Art {Id = 1, Name = "Kaneki Kun", Author = "Olzhasinho", Description = "Ken Kaneki (金木 研, Kaneki Ken) is the main protagonist of the Tokyo Ghoul series. He is currently Touka Kirishima's husband, and the father of Ichika Kaneki. Previously, he was a student who studied Japanese literature at Kamii University, living a relatively normal life.", Size = "1920x1080", Price = 1000, ImageUrl = "/images/1.jpg", ImageThumbnailUrl = "/images/1.jpg" }
            };
        }
        public IEnumerable<Art> GetAllArts()
        {
            return _arts;
        }

        public Art GetArtById(int ArtId)
        {
            return _arts.FirstOrDefault(a => a.Id == ArtId);
        }
    }
}
