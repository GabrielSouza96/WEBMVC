using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEBMVC.Models;

namespace WEBMVC.Data
{
    public class WEBMVCContext : DbContext
    {
        public WEBMVCContext (DbContextOptions<WEBMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WEBMVC.Models.Department> Department { get; set; }
    }
}
