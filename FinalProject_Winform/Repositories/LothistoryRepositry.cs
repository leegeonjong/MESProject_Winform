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
    internal class LothistoryRepositry : ILothistoryRepository
    {
        public async Task<LotHistory> AddLotAsync(long lotid, long processid, string status)
        {
            using FinalDbContext db = new();
            //var lothistory = await db.LotHistorys.Where(x => x.LotId == lotid).Where(x=> x.ProcessId == processid).FirstAsync();
            //if (lothistory == null) return null;
            LotHistory lothistory = new()
            {
                LotId = lotid,
                ProcessId = processid,
                LotHistory_Date = DateTime.Now,
                LotHistory_status = status,
            };

            await db.LotHistorys.AddAsync(lothistory);
            await db.SaveChangesAsync();
            return lothistory;
        }
    }
}
