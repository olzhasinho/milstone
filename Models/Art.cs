﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.Models
{
    public class Art
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }
        public string Description { get; set; }
        
        public string Size { get; set; }

        public int Price { get; set; }

        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}
