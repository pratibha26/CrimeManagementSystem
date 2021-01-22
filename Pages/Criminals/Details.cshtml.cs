using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Criminals
{
    public class DetailsModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public DetailsModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        public Criminal Criminal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Criminal = await _context.Criminals.FirstOrDefaultAsync(m => m.Id == id);

            if (Criminal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
