using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    internal interface IOrderRepository
    {

        public Task<long> GetByIdAsync(long id);

        public Task<Order> GetByNameAsync(string name);


		public Task<string> GetStatusByIdAsync(long id);

        public Task<Order> AddAsync(DateTime startDate, DateTime endDate, string ordername, long ordercount, string account, string itemname);

        public Task<Order> OrderUpdateAsync(long orderId);
    }
}
