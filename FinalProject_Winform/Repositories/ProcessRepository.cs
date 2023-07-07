using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    public class ProcessRepository : IProcessRepository
    {
        public async Task<IEnumerable<Process>> GetAllAsync()
        {
            using FinalDbContext db = new();
            var process = await db.Processes
                .Include(s => s.lot)
                .Include(s => s.lotHistory)
                .ToListAsync();
            return process.OrderByDescending(x => x.Id).ToList();
        }
    }
}
