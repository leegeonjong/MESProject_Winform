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

        public async Task<Item> UpdateAsync(string name,long amount)
        {
            using FinalDbContext db = new();
            var existingItem = await db.Items.Where(x => x.Item_name == name).FirstAsync();

            if (existingItem == null) return null;

            existingItem.Item_amount += amount;
          
            await db.SaveChangesAsync();
            return existingItem;
        }
    }
}
