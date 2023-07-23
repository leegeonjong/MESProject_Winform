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

            if (item.Item_amount < amount)
            {
                MessageBox.Show("가진 아이템의 수량이 LOT 생성에 필요한 아이템 수량보다 적습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (item.Item_amount > amount)
            {
                item.Item_amount -= amount;

                Lot lot = new()
                {
                    Item = item,
                    Lot_barcode = barcode,
                    Lot_amount = amount,
                    Lot_regDate = DateTime.Now,
                    Lot_status = "created",
                    Lot_break = false

                };

                Stock stock = new()
                {
                    Item = item,
                    Stock_amount = -amount,
                    Stock_regDate = DateTime.Now,
                    Stock_status = "Lot 생성",
                };

                var lastStock = await db.Stocks
              .Where(x => x.Item.Id == item.Id)
              .OrderByDescending(x => x.Stock_regDate)
              .FirstOrDefaultAsync();

                if (lastStock != null)
                {
                    stock.Stock_regAmount = lastStock.Stock_regAmount - amount;
                }
                else
                {
                    stock.Stock_regAmount = amount;
                }

                await db.Lots.AddAsync(lot);
                await db.Stocks.AddAsync(stock);
                await db.SaveChangesAsync();
                return lot;
            }

            else
            {
                MessageBox.Show("재고의 수량이 LOT생성에 필요한 재고 수량보다 작습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

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
            return Lot.OrderByDescending(x => x.Lot_regDate).ToList();
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

        public long FindLotPkByBarcode(string barcode)
        {
            using FinalDbContext db = new();
            var lot = db.Lots.FirstOrDefault(l => l.Lot_barcode == barcode);
            return lot?.Id ?? 0;
        }

        public string FindBarcodePkByPK(long lotId)
        {
            using FinalDbContext db = new();
            var lot = db.Lots.FirstOrDefault(l => l.Id == lotId);
            return lot.Lot_barcode;
        }
        public async Task<Lot> Updateasync(string status, long lotpk)
        {
            using FinalDbContext db = new();
            var lot = await db.Lots.Where(x => x.Id == lotpk).FirstOrDefaultAsync();
            if (lot == null) return null;

            lot.Lot_status = status;

            await db.SaveChangesAsync();
            return lot;
        }

        public bool Findstatus(string status)
        {
            using FinalDbContext db = new();
            var lot = db.Lots.FirstOrDefault(l => l.Lot_status == status);

            if (lot != null)
            {
                // status와 일치하는 Lot이 존재하는 경우
                return false;
            }
            else
            {
                // status와 일치하는 Lot이 존재하지 않는 경우
                return true;
            }
        }

        public async Task<Lot> ItemUpdateAsync(long lotpk)
        {
            using (FinalDbContext db = new FinalDbContext())
            {
                var lot = await db.Lots
                    .Include(x => x.Item)
                    .Where(x => x.Id == lotpk)
                    .FirstOrDefaultAsync();

                if (lot == null)
                    return null;

                if (lot.Item.Id == 1)
                {
                    await UpdateLotItem1Async(db, lot);
                }
                else if (lot.Item.Id == 2)
                {
                    await UpdateLotItem2Async(db, lot);
                }

                await db.SaveChangesAsync();
                return lot;
            }
        }

        private async Task UpdateLotItem1Async(FinalDbContext db, Lot lot)
        {
            var item2 = await db.Items.FirstOrDefaultAsync(x => x.Id == 2);
            lot.Item = item2;

            item2.Item_amount += lot.Lot_amount;

            Stock stock = new Stock()
            {
                Item = item2,
                Stock_amount = lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "반죽됨",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Id == item2.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            if (lastStock != null)
            {
                stock.Stock_regAmount = lastStock.Stock_regAmount + lot.Lot_amount;
            }
            else
            {
                stock.Stock_regAmount = lot.Lot_amount;
            }

            await db.Stocks.AddAsync(stock);
        }

        private async Task UpdateLotItem2Async(FinalDbContext db, Lot lot)
        {
            var item3 = await db.Items.FirstOrDefaultAsync(x => x.Id == 3);
            var item2 = await db.Items.FirstOrDefaultAsync(x => x.Id == 2);

            lot.Item = item3;

            long noodleEA = lot.Lot_amount / 100;

            item3.Item_amount += noodleEA;
            item2.Item_amount -= lot.Lot_amount;

            Stock stock = new Stock()
            {
                Item = item3,
                Stock_amount = noodleEA,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 형태화",
            };

            Stock stock1 = new Stock()
            {
                Item = item2,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 형태화",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Id == item3.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock1 = await db.Stocks
                .Where(x => x.Item.Id == item2.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            if (lastStock != null)
            {
                stock.Stock_regAmount = lastStock.Stock_regAmount + noodleEA;
            }
            else
            {
                stock.Stock_regAmount = noodleEA;
            }

            if (lastStock1 != null)
            {
                stock1.Stock_regAmount = lastStock1.Stock_regAmount - lot.Lot_amount;
            }
            else
            {
                stock1.Stock_regAmount = lot.Lot_amount;
            }

            lot.Lot_amount = noodleEA;

            await db.Stocks.AddAsync(stock);
            await db.Stocks.AddAsync(stock1);
        }


    }
}
