using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtShop.Models;
using ArtShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArtShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArtRepository _artRepository;

        public HomeController(ArtRepository artRepository)
        {
            _artRepository = artRepository;   
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            var arts = _artRepository.GetAllArts().OrderBy(a => a.Name);
           
            var homeViewModel = new HomeViewModel()
            
            {
                Title = "Olzhasinho ArtSHOP",
                Arts = arts.ToList()
            };
            return View(homeViewModel);
        }
        
        public IActionResult Details(int id)
        {
            var art = _artRepository.GetArtById(id);
            if (art == null)
                return NotFound();
            return View(art);
        }
    }
}
