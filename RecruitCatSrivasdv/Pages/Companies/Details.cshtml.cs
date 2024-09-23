using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSrivasdv.Data;
using RecruitCatSrivasdv.Models;

namespace RecruitCatSrivasdv.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSrivasdv.Data.RecruitCatSrivasdvContext _context;

        public DetailsModel(RecruitCatSrivasdv.Data.RecruitCatSrivasdvContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Company
                .Include(c => c.Candidates).FirstOrDefaultAsync(m => m.ID == id);
            if (company == null)
            {
                return NotFound();
            }
            else
            {
                Company = company;
            }
            return Page();
        }
    }
}
