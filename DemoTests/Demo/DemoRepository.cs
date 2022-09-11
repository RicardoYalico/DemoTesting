using DemoTests.AppDemoContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTests.Demo
{
    public class DemoRepository : IDemoRepository
    {
        protected readonly AppDbContext _context;

        public DemoRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IEnumerable<DemoModel>> FindAsync()
        {
            return await _context.DemoModels.ToListAsync();
        }

        public bool getAuthById(int id)
        {
            return _context.DemoModels.FindAsync(id).Result.isAuthenticated;
        }
    }
}
