using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBMVC.Models;
using WEBMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace WEBMVC.Services
{
    public class DepartmentService
    {
        private readonly WEBMVCContext _context;

        public DepartmentService(WEBMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
