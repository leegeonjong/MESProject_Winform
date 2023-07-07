using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    internal interface IStockRepository
    {
        Task<IEnumerable<Item>> GetAllAsync(); // 아이템 목록 불러오기

        Task<Stock> AddAsync (Item item, long amount); // 입출고 추가
    }
}
