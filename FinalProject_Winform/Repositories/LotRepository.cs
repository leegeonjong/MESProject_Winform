using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    internal class LotRepository : ILotRepository
    {
        public Task<Lot> AddAsync(Lot Lot)
        {
          using FinalDbContext dbContext = new();
            dbContext
        }

        public Task<IEnumerable<Lot>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
