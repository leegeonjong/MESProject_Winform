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

        public async Task<Item?> GetByNameAsync(string name)
        {
            using FinalDbContext db = new();
           var item = await db.Items.FirstOrDefaultAsync(i => i.Item_name == name);
            return item;
        }

        public Task<Item> UpdateAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
