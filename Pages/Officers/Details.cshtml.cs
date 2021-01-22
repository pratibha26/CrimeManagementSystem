using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Officers
{
    public class DetailsModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public DetailsModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        public Officer Officer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Officer = await _context.Officers.FirstOrDefaultAsync(m => m.Id == id);

            if (Officer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
