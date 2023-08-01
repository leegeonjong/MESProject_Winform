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
                    Lot_break = true,

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
            var Lot = await db.Lots.Include(i => i.Item).ToListAsync();
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

        public async Task UpdateLotbreak(long lotpk , bool pass)
        {
            using FinalDbContext db = new();
            var lot = db.Lots.FirstOrDefault(l => l.Id == lotpk);
            lot.Lot_break = pass;

            await db.SaveChangesAsync();
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
                else if (lot.Item.Id == 3)
                {
                    await UpdateLotItem3Async(db, lot);
                }
                else if (lot.Item.Id == 4)
                {
                    await UpdateLotItem4Async(db, lot);
                }
                else if (lot.Item.Id == 5)
                {
                    await UpdateLotItem5Async(db, lot);
                }
                else if (lot.Item.Id == 6)
                {
                    await UpdateLotItem6Async(db, lot);
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
        private async Task UpdateLotItem3Async(FinalDbContext db, Lot lot)
        {
            var item4 = await db.Items.FirstOrDefaultAsync(x => x.Id == 4);
            var item3 = await db.Items.FirstOrDefaultAsync(x => x.Id == 3);

            lot.Item = item4;

            item4.Item_amount += lot.Lot_amount;
            item3.Item_amount -= lot.Lot_amount;

            Stock stock = new Stock()
            {
                Item = item4,
                Stock_amount = lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 찌기",
            };

            Stock stock1 = new Stock()
            {
                Item = item3,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 찌기",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Id == item4.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock1 = await db.Stocks
                .Where(x => x.Item.Id == item3.Id)
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

            if (lastStock1 != null)
            {
                stock1.Stock_regAmount = lastStock1.Stock_regAmount - lot.Lot_amount;
            }
            else
            {
                stock1.Stock_regAmount = lot.Lot_amount;
            }

            await db.Stocks.AddAsync(stock);
            await db.Stocks.AddAsync(stock1);


        }

        private async Task UpdateLotItem4Async(FinalDbContext db, Lot lot)
        {
            var item5 = await db.Items.FirstOrDefaultAsync(x => x.Id == 5);
            var item4 = await db.Items.FirstOrDefaultAsync(x => x.Id == 4);
            var item10 = await db.Items.FirstOrDefaultAsync(x => x.Id == 10);

            lot.Item = item5;

            item5.Item_amount += lot.Lot_amount;
            item4.Item_amount -= lot.Lot_amount;
            item10.Item_amount -= 200;

            Stock stock = new Stock()
            {
                Item = item5,
                Stock_amount = lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 튀기기",
            };

            Stock stock1 = new Stock()
            {
                Item = item4,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 튀기기",
            };


            Stock stock2 = new Stock()
            {
                Item = item10,
                Stock_amount = -200,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 튀기기",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Id == item5.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock1 = await db.Stocks
                .Where(x => x.Item.Id == item4.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock2 = await db.Stocks
                .Where(x => x.Item.Id == item10.Id)
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

            if (lastStock1 != null)
            {
                stock1.Stock_regAmount = lastStock1.Stock_regAmount - lot.Lot_amount;
            }
            else
            {
                stock1.Stock_regAmount = lot.Lot_amount;
            }

            if (lastStock2 != null)
            {
                stock2.Stock_regAmount = lastStock2.Stock_regAmount - 200;
            }

            else
            {
                stock2.Stock_regAmount = -200;
            }

            await db.Stocks.AddAsync(stock);
            await db.Stocks.AddAsync(stock1);
            await db.Stocks.AddAsync(stock2);
        }

        private async Task UpdateLotItem5Async(FinalDbContext db, Lot lot)
        {
            var item6 = await db.Items.FirstOrDefaultAsync(x => x.Id == 6);
            var item5 = await db.Items.FirstOrDefaultAsync(x => x.Id == 5);

            lot.Item = item6;

            item6.Item_amount += lot.Lot_amount;
            item5.Item_amount -= lot.Lot_amount;

            Stock stock = new Stock()
            {
                Item = item6,
                Stock_amount = lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 얼리기",
            };

            Stock stock1 = new Stock()
            {
                Item = item5,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "면 얼리기",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Id == item6.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock1 = await db.Stocks
                .Where(x => x.Item.Id == item5.Id)
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

            if (lastStock1 != null)
            {
                stock1.Stock_regAmount = lastStock1.Stock_regAmount - lot.Lot_amount;
            }
            else
            {
                stock1.Stock_regAmount = lot.Lot_amount;
            }

            await db.Stocks.AddAsync(stock);
            await db.Stocks.AddAsync(stock1);
        }

        private async Task UpdateLotItem6Async(FinalDbContext db, Lot lot)
        {
            var item11 = await db.Items.FirstOrDefaultAsync(x => x.Id == 11);
            var item6 = await db.Items.FirstOrDefaultAsync(x => x.Id == 6);
            var item7 = await db.Items.FirstOrDefaultAsync(x => x.Id == 7);
            var item8 = await db.Items.FirstOrDefaultAsync(x => x.Id == 8);
            var item9 = await db.Items.FirstOrDefaultAsync(x => x.Id == 9);

            lot.Item = item11;

            item11.Item_amount += lot.Lot_amount;
            item6.Item_amount -= lot.Lot_amount;
            item7.Item_amount -= lot.Lot_amount;
            item8.Item_amount -= lot.Lot_amount;
            item9.Item_amount -= lot.Lot_amount;

            Stock stock = new Stock()
            {
                Item = item11,
                Stock_amount = lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "라면 포장",
            };

            Stock stock1 = new Stock()
            {
                Item = item6,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "라면 포장",
            };


            Stock stock2 = new Stock()
            {
                Item = item7,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "라면 포장",
            };

            Stock stock3 = new Stock()
            {
                Item = item8,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "라면 포장",
            };

            Stock stock4 = new Stock()
            {
                Item = item9,
                Stock_amount = -lot.Lot_amount,
                Stock_regDate = DateTime.Now,
                Stock_status = "라면 포장",
            };

            var lastStock = await db.Stocks
                .Where(x => x.Item.Id == item11.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock1 = await db.Stocks
                .Where(x => x.Item.Id == item6.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock2 = await db.Stocks
                .Where(x => x.Item.Id == item7.Id)
                .OrderByDescending(x => x.Stock_regDate)
                .FirstOrDefaultAsync();

            var lastStock3 = await db.Stocks
            .Where(x => x.Item.Id == item8.Id)
            .OrderByDescending(x => x.Stock_regDate)
            .FirstOrDefaultAsync();

            var lastStock4 = await db.Stocks
              .Where(x => x.Item.Id == item9.Id)
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

            if (lastStock1 != null)
            {
                stock1.Stock_regAmount = lastStock1.Stock_regAmount - lot.Lot_amount;
            }
            else
            {
                stock1.Stock_regAmount = lot.Lot_amount;
            }

            if (lastStock2 != null)
            {
                stock2.Stock_regAmount = lastStock2.Stock_regAmount -lot.Lot_amount;
            }

            else
            {
                stock2.Stock_regAmount = -lot.Lot_amount;
            }

            if (lastStock3 != null)
            {
                stock3.Stock_regAmount = lastStock3.Stock_regAmount -lot.Lot_amount;
            }

            else
            {
                stock3.Stock_regAmount = -lot.Lot_amount;
            }

            if (lastStock4 != null)
            {
                stock4.Stock_regAmount = lastStock4.Stock_regAmount - lot.Lot_amount;
            }

            else
            {
                stock4.Stock_regAmount = -lot.Lot_amount;
            }

            await db.Stocks.AddAsync(stock);
            await db.Stocks.AddAsync(stock1);
            await db.Stocks.AddAsync(stock2);
            await db.Stocks.AddAsync(stock3);
            await db.Stocks.AddAsync(stock4);
        }

        public async Task<Lot> deleteLotAsync(long lotpk)
        {
            using FinalDbContext db = new();
            // 주어진 lotpk에 해당하는 lot를 찾습니다.
            var lotToDelete = await db.Lots.FindAsync(lotpk);

            if (lotToDelete == null)
            {
                throw new ArgumentException("해당 lotpk에 해당하는 lot를 찾을 수 없습니다.");
            }

            // lot를 삭제합니다.
            db.Lots.Remove(lotToDelete);

            // 변경 사항을 저장합니다.
            await db.SaveChangesAsync();
            return lotToDelete;
        }

        public bool FindLotBreak(string lotBarcode)
        {
            using FinalDbContext db = new();
            var lot = db.Lots.FirstOrDefault(l => l.Lot_barcode == lotBarcode);
            bool lot_break = lot.Lot_break; 
            return lot_break;
        }
    }
}
