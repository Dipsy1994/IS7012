using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSrivasdv.Models;

namespace RecruitCatSrivasdv.Data
{
    public class RecruitCatSrivasdvContext : DbContext
    {
        public RecruitCatSrivasdvContext (DbContextOptions<RecruitCatSrivasdvContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSrivasdv.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatSrivasdv.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatSrivasdv.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatSrivasdv.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
