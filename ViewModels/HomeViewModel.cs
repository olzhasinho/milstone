using ArtShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Art> Arts { get; set; }
    }
}
