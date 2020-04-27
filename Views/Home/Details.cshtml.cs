using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArtShop.Models;

namespace ArtShop.Views.CRUD
{
    public class DetailsModel : PageModel
    {
        private readonly ArtShop.Models.AppDbContext _context;

        public DetailsModel(ArtShop.Models.AppDbContext context)
        {
            _context = context;
        }

        public Art Art { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Art = await _context.Arts.FirstOrDefaultAsync(m => m.Id == id);

            if (Art == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
