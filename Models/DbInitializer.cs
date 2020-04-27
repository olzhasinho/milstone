using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Arts.Any())
            {
                context.AddRange
                (
                    new Art {Name = "Kaneki Kun", Author = "Olzhasinho", Description = "Ken Kaneki (金木 研, Kaneki Ken) is the main protagonist of the Tokyo Ghoul series. He is currently Touka Kirishima's husband, and the father of Ichika Kaneki. Previously, he was a student who studied Japanese literature at Kamii University, living a relatively normal life.", Size = "1920x1080", Price = 1000, ImageUrl = "/images/1.jpg", ImageThumbnailUrl = "/images/1.jpg" },
                    new Art { Name = "Douzuu", Author = "Arai tusuki", Description = "Il crudele bidello Tasuku Kurosaki la costringerà a lavorare per lui per ripagare il ... Tetsuya Arai era il precedente insegnante", Size = "1920x1080", Price = 4000, ImageUrl = "/images/2.jpg", ImageThumbnailUrl = "/images/2.jpg" }
                );

                context.SaveChanges();

            }
        }
    }
}
