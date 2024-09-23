using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatSrivasdv.Data;
using RecruitCatSrivasdv.Models;

namespace RecruitCatSrivasdv.Pages.Industries
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
            return Page();
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Industry.Add(Industry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
