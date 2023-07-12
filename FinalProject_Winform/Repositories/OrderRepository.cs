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
    public class OrderRepository : IOrderRepository
    {
        public async Task<long> GetByIdAsync(long id)
        {
            using FinalDbContext db = new();
            var order = await db.Orders
                .Include(x=>x.Item)
                .Where(i => i.Id == id)
                
                .FirstAsync();
            return order.Order_count;
        }
    }
}
