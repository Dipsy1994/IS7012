using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSrivasdv.Data;
using RecruitCatSrivasdv.Models;

namespace RecruitCatSrivasdv.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSrivasdv.Data.RecruitCatSrivasdvContext _context;

        public DetailsModel(RecruitCatSrivasdv.Data.RecruitCatSrivasdvContext context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.ID == id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            else
            {
                JobTitle = jobtitle;
            }
            return Page();
        }
    }
}
