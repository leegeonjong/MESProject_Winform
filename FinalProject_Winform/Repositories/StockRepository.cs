using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Winform.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly IItemRepository itemRepository;
        public StockRepository() {
            itemRepository = new ItemRepository();
        }
      
        public async Task<Tuple<Stock, long>> AddAsync(string itemname,long amount)
        {
            using FinalDbContext db = new();
            var item = await db.Items.Where(x => x.Item_name == itemname).FirstAsync();
            long i_amount = item.Item_amount + amount;
            if (item == null) return null;

            
            Stock stock = new()
            {
                Item = item,
                Stock_amount = amount, 
               Stock_regDate = DateTime.Now, 
               Stock_status =  "입고",
            };

            var lastStock = await db.Stocks
                .Where(x=>x.Item.Item_name==itemname)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            if (lastStock != null)
            {
                stock.Stock_regAmount = lastStock.Stock_regAmount + amount;
            }
            else
            {
                stock.Stock_regAmount = amount;
            }


            await db.Stocks.AddAsync(stock);
            await db.SaveChangesAsync();
            return new Tuple<Stock, long>(stock, i_amount);
        }

        public async Task<IEnumerable<Stock>> GetAllAsync()
        {
            using FinalDbContext db = new();
            var stocks = await db.Stocks
                .Include(s=>s.Item)
                .ToListAsync();
            return stocks.OrderByDescending(x => x.Id).ToList();


        }

        public async Task<Stock> MinusAsync(long orderId)
        {
            using FinalDbContext db = new();
            var order = await db.Orders
                .Include(s=>s.Item)
                .Where(x => x.Id == orderId)
                .FirstAsync();

            if (order == null) return null;

            var item = await db.Items.Where(x => x.Id == order.Item.Id).FirstOrDefaultAsync();
            if (item == null) return null;
   

            Stock stock = new()
            {
                Item = item,
                Stock_amount = -order.Order_count,
                Stock_regDate = DateTime.Now,
                Stock_status = "출고",
            };

          


            await db.Stocks.AddAsync(stock);
            await db.SaveChangesAsync();
            return stock;
        }
    }
}
