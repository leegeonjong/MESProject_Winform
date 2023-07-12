using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    public interface ILotRepository
    {
        Task<Lot> AddLotAsync(string itemname, string barcode, long amount);
        Task<IEnumerable<Lot>> GetAllAsync();

        Task<IEnumerable<Lot>> GetByBarcode(string Barcode);
        Task<IEnumerable<Lot>> GetByItem(string Item);
        Task<IEnumerable<Lot>> GetByCount(int count);

        bool FindAsync(string barcode);
    }
}
