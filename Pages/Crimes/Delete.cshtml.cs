using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Crimes
{
    public class DeleteModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public DeleteModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Crime Crime { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crime = await _context.Crimes
                .Include(c => c.Criminal)
                .Include(c => c.Officer)
                .Include(c => c.Victim).FirstOrDefaultAsync(m => m.Id == id);

            if (Crime == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crime = await _context.Crimes.FindAsync(id);

            if (Crime != null)
            {
                _context.Crimes.Remove(Crime);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
