using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    public class LotRepository : ILotRepository
    {
       
        public async Task<Lot> AddAsync(Lot Lot)
        {
            using FinalDbContext db = new();
            await db.Lots.AddAsync(Lot);
            await db.SaveChangesAsync();    
            return Lot;

        }

        public bool FindAsync(string barcode)
        {
            using FinalDbContext db = new();

            var jobs = db.Lots.Where(j => j.Lot_barcode == barcode);
            if (jobs.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<IEnumerable<Lot>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

  
    }
}
