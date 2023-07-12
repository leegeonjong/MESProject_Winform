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

        Task<Item> UpdateAsync(string name,long amount); // 수정

        Task<IEnumerable<Item>> GetAllAsync();
    }
}
