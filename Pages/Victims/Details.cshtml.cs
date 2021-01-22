using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Victims
{
    public class DetailsModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public DetailsModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        public Victim Victim { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Victim = await _context.Victims.FirstOrDefaultAsync(m => m.Id == id);

            if (Victim == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
