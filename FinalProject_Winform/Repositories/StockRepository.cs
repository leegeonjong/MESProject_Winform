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

        public async Task<Stock> AddAsync(string itemname, long amount)
        {
            using FinalDbContext db = new();
            var item = await db.Items.Where(x => x.Item_name == itemname).FirstAsync();
            if (item == null) return null;


            Stock stock = new()
            {
                Item = item,
                Stock_amount = amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "입고",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Item_name == itemname)
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
            return stock;
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

            
            long ordercount = order.Order_count;
            if (order == null) return null;

            var item = await db.Items.Where(x => x.Id == order.Item.Id).FirstOrDefaultAsync();
            if (item == null) return null;

            if (item.Item_amount >= ordercount) { 
            

                Stock stock = new()
                {
                Item = item,
                Stock_amount = -order.Order_count,
                Stock_regDate = DateTime.Now,
                Stock_status = "출고",
                 };

                var lastStock = await db.Stocks
               .Where(x => x.Item.Id == item.Id)
               .OrderByDescending(x => x.Stock_regDate)
               .FirstOrDefaultAsync();

                if (lastStock != null)
                {
                    stock.Stock_regAmount = lastStock.Stock_regAmount - ordercount;
                }
                else
                {
                    stock.Stock_regAmount = ordercount;
                }
                await db.Stocks.AddAsync(stock);
                await db.SaveChangesAsync();
                return stock;
            }

            else
            {
                throw new Exception("아이템 수량이 출고할 수량보다 작습니다.");
            }


        }
    }
}
