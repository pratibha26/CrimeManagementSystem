using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Officers
{
    public class EditModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public EditModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Officer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfficerExists(Officer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OfficerExists(int id)
        {
            return _context.Officers.Any(e => e.Id == id);
        }
    }
}
