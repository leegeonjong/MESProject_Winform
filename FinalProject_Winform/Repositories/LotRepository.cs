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
    public class LotRepository : ILotRepository
    {

        public async Task<Lot> AddLotAsync(string itemname, string barcode, long amount)
        {
            using FinalDbContext db = new();
            var item = await db.Items.Where(x => x.Item_name == itemname).FirstAsync();
            if (item == null) return null;
            Lot lot = new()
            {
                Item = item,
                Lot_barcode = barcode,
                Lot_amount = amount,
                Lot_regDate = DateTime.Now,
                Lot_status = "created",
                Lot_break = false

            };

            await db.Lots.AddAsync(lot);
            await db.SaveChangesAsync();
            return lot;

        }

        public bool FindAsync(string barcode)
        {
            using FinalDbContext db = new();

            var jobs = db.Lots.Where(j => j.Lot_barcode == barcode);
            if (jobs.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<Lot>> GetAllAsync()
        {
            using FinalDbContext db = new();
            var Lot = await db.Lots.Include(i=>i.Item).ToListAsync();
            return Lot.OrderBy(x => x.Id).ToList();
        }

        public async Task<IEnumerable<Lot>> GetByBarcode(string Barcode)
        {
            using FinalDbContext db = new();
            return await db.Lots.Include(i => i.Item).Where(i => i.Lot_barcode == Barcode).ToListAsync();
        }

        public async Task<IEnumerable<Lot>> GetByItem(string Item)
        {
            using FinalDbContext db = new();
            return await db.Lots.Include(i => i.Item).Where(i => i.Item.Item_name == Item).ToListAsync();
        }

        public async Task<IEnumerable<Lot>> GetByCount(int count)
        {
            using FinalDbContext db = new();
            return await db.Lots.Include(i => i.Item).Where(i => i.Lot_amount == count).ToListAsync();
        }
    }
}
