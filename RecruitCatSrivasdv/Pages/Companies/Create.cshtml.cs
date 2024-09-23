using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatSrivasdv.Data;
using RecruitCatSrivasdv.Models;

namespace RecruitCatSrivasdv.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatSrivasdv.Data.RecruitCatSrivasdvContext _context;

        public CreateModel(RecruitCatSrivasdv.Data.RecruitCatSrivasdvContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
