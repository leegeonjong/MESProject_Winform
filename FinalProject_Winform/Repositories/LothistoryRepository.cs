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
    internal class LothistoryRepository : ILothistoryRepository
    {
        public async Task<LotHistory> AddLotAsync(long lotid, long processid, string status)
        {
            using FinalDbContext db = new();
            var process = db.Processes
                .Include(x => x.Check)
                .FirstOrDefault(x => x.Id == processid);

            long? checkid = process.Check?.Id; // Use the null-conditional operator

            if (checkid == 0)
            {
                checkid = null;
            }

            LotHistory lothistory = new()
            {
                LotId = lotid,
                ProcessId = processid,
                LotHistory_Date = DateTime.Now,
                LotHistory_status = status,
                CheckId = checkid ?? 0, 
            };

            await db.LotHistorys.AddAsync(lothistory);
            await db.SaveChangesAsync();
            return lothistory;
        }

        public async Task<LotHistory> SaveTestData(long lotid, long processid, long checkResult)
        {
            using FinalDbContext db = new();

            // 해당 lotid와 processid에 해당하는 LotHistory 데이터 조회
            var lothistory = await db.LotHistorys
                .FirstOrDefaultAsync(x => x.LotId == lotid && x.ProcessId == processid);

            if (lothistory != null)
            {
                // 검사 결과 업데이트
                lothistory.CheckResult = checkResult.ToString();

                // 변경 사항을 데이터베이스에 저장
                await db.SaveChangesAsync();
            }
            return lothistory;
        }

        public async Task<long> GetRecentLotAsync(long processid)
        {
            using FinalDbContext db = new();
            var lot = await db.LotHistorys
                .Where(i => i.ProcessId == processid)
                .OrderByDescending(i => i.LotHistory_Date)
                .Select(i => i.LotId)
                .FirstOrDefaultAsync();

            return lot;
        }

        public async Task<List<LotHistory>> GetLotId(string processName)
        {
            using FinalDbContext db = new();
            var lots = await db.LotHistorys
                .Where(i => i.Process.Process_name == processName)
                .OrderByDescending(i => i.LotHistory_Date)
                .ToListAsync();

            return lots;
        }

    }
}
