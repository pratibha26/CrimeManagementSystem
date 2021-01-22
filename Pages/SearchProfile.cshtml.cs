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
    public class SearchProfileModel : PageModel
    {
        private AppDbContext _context;

    public SearchProfileModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            SearchCompleted = false;
        }

    [BindProperty]
        public string Search { get; set; }
        
        // WE WILL USE THIS PROPERTY TO TRACK IF A SEARCH HAS BEEN PERFORMED
        public bool SearchCompleted { get; set; }
        public ICollection<Crime> SearchResult { get; set; }

public void OnPost() {
            // PERFORM SEARCH
            if (string.IsNullOrWhiteSpace(Search)) {
                // EXIT EARLY IF THERE IS NO SEARCH TERM PROVIDED
                return;
            }
    
            SearchResult = _context.Crimes
                                    .Include(x => x.Officer)
                                    .Include(x => x.Victim)
                                    .Include(z=>z.Criminal)
                                    .Where(x => (x.Victim.Name.ToLower().Contains(Search.ToLower())) ||  x.Criminal.Name.ToLower().Contains(Search.ToLower()) || x.Officer.Name.ToLower().Contains(Search.ToLower()))
                                    .ToList();
            
            SearchCompleted = true;
        }
    }
}