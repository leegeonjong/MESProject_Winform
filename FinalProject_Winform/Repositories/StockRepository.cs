using BarcodeStandard;
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
        private readonly IItemRepository itemRepository;
        public StockRepository() { 
        
        }
      
        public async Task<Stock> AddAsync(Item itemname,long amount)
        {
            using FinalDbContext db = new();

            Stock stock = new()
            {
                Item = itemname,
                Stock_amount = amount,
               Stock_regDate = DateTime.Now, 
               Stock_status =  "입고",

            };

            await db.Stocks.AddAsync(stock);
            await db.SaveChangesAsync();
            return stock;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            using FinalDbContext db = new();
            var items = await db.Items.ToListAsync();
            return items.OrderBy(x => x.Id).ToList();
        }
    }
}
