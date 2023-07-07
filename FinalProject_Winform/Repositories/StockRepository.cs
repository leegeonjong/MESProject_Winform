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
    public class StockRepository : IStockRepository
    {
        public Task<Stock> AddAsync(Stock stock)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            using FinalDbContext db = new();
            var items = await db.Items.ToListAsync();
            return items.OrderBy(x => x.Id).ToList();
        }
    }
}
