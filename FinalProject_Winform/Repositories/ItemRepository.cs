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
    internal class ItemRepository : IItemRepository
    {
        public ItemRepository()
        {

        }
        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            using FinalDbContext db = new();

            var items = await db.Items.ToListAsync();
            return items.OrderBy(x => x.Id).ToList();
        }

        public async Task<Item> ImportUpdateAsync(string name, long amount)
        {
            using FinalDbContext db = new();
            var existingItem = await db.Items.Where(x => x.Item_name == name).FirstAsync();

            if (existingItem == null) return null;

            existingItem.Item_amount += amount;

            await db.SaveChangesAsync();
            return existingItem;
        }
        public async Task<Item> ExportUpdateAsync(long orderId, long amount)
        {
            using FinalDbContext db = new();
            var existingItem = await db.Items.Where(x => x.Id == orderId).FirstOrDefaultAsync();

            if (existingItem == null)
            {
                // 존재하지 않는 아이템이면 오류 반환
                throw new Exception("존재하지 않는 아이템입니다.");
            }

            if (existingItem.Item_amount < amount)
            {
                // 아이템의 수량이 출고할 수량보다 작으면 오류 반환
                throw new Exception("아이템의 수량이 출고할 수량보다 작습니다.");
            }

            existingItem.Item_amount -= amount;

            await db.SaveChangesAsync();
            return existingItem;
        }

    }
}
