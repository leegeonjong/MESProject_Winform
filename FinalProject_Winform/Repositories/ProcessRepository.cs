using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    internal class ProcessRepository : IProcessRepository
    {
        private readonly IProcessRepository processRepository;
        public ProcessRepository() { 
            processRepository = new ProcessRepository(); 
        }

        public async Task<IEnumerable<Process>> GetAllAsync()
        {
            // using FinalDbContext db = new();
            //var process = await db.Processes.Where(x => x.)
            throw new NotImplementedException();
        }
    }
}
