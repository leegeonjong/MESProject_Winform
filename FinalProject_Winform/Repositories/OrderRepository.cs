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

        public async Task<Order> AddAsync
            (
             DateTime startDate,DateTime endDate,string ordername,long ordercount, string account,string itemname
            )
        {
            using FinalDbContext db = new();
            var item = await db.Items.Where(x => x.Item_name == itemname).FirstAsync();
            if (item == null) return null;


            Order order = new()
            {
                Item = item,
                Order_startDate = startDate,
                Order_endDate = endDate,   // FK
                Order_status = "주문 제작 중",
                Order_name = ordername,
                Order_count = ordercount,
                Order_account = account,

            };

            await db.Orders.AddAsync(order);
            await db.SaveChangesAsync();
            return order;
        }
    }
}
