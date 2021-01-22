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
    public class OfficerProfileModel : PageModel
    {
        private AppDbContext _context;

        public OfficerProfileModel(AppDbContext context){
            _context = context;
        }

        public Officer Officer { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Officer = _context.Officers.Include(est => est.Crimes).ThenInclude(y => y.Victim).Include(z=>z.Crimes).ThenInclude(x=>x.Criminal).FirstOrDefault(est => est.Id == id);
            
            if(Officer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}