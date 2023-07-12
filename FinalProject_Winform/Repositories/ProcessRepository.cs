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
            //using FinalDbContext db = new();
            //var process = await db.Processes
            //    .Include(s => s.lot)
            //    .Include(s => s.lotHistory)
            //    .ToListAsync();
            //return process.OrderByDescending(x => x.Id).ToList();
            throw new NotImplementedException();
        }

        public async Task<string> GetSelectedProcessStatus(string selectedProcessName)
        {
            using (FinalDbContext db = new FinalDbContext())
            {
                var process = await db.Processes
            .Where(p => p.Process_name == selectedProcessName)
            .FirstOrDefaultAsync();

                if (process != null)
                {
                    return process.Process_status.ToString();
                }
                else
                {
                    throw new Exception("그런건 없음");
                }
            }
        }

        public async Task<bool> IsRunningAsync(bool state, string selectedProcessName)
        {
            using FinalDbContext db = new();
            var process = await db.Processes
                .Where(p => p.Process_name == selectedProcessName)
                .FirstOrDefaultAsync();

            if (process != null)
            {
                if (state == true)
                {
                    process.Process_status = true;
                }
                else
                {
                    process.Process_status = false;
                }
                await db.SaveChangesAsync();

                return true;
            }
            else
            {
                throw new Exception("그런거 없음");
            }
        }
    }
}
