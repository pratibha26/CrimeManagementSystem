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
    public class DeleteModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public DeleteModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Victim = await _context.Victims.FindAsync(id);

            if (Victim != null)
            {
                _context.Victims.Remove(Victim);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
