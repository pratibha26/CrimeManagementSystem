using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrimeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CrimeManagementSystem.Pages
{
    public class VictimProfileModel : PageModel
    {
        private AppDbContext _context;

        public VictimProfileModel(AppDbContext context){
            _context = context;
        }

        public Victim Victim { get; set; }
        public IActionResult OnGet(int? id)
        {
             if (id == null)
             {
                 return NotFound();
             }
             Victim = _context.Victims.Include(est => est.Crimes).ThenInclude(y => y.Officer).Include(z=>z.Crimes).ThenInclude(x=>x.Criminal).FirstOrDefault(est => est.Id == id);
             if(Victim == null)
             {
                 return NotFound();
             }
             return Page();
        }
    }
}