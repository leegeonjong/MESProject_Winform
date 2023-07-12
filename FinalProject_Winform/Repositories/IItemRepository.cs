using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    internal interface IItemRepository
    {

        Task<Item> ImportUpdateAsync(string name,long amount); // 수정

        Task<Item> ExportUpdateAsync(long orderId,long amount);

        Task<IEnumerable<Item>> GetAllAsync();


    }
}
