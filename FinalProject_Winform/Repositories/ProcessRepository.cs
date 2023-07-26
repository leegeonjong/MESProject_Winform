using FinalProject_Winform.Data;
using Process = FinalProject_Winform.Models.domain.Process;

namespace FinalProject_Winform.Repositories
{
    public class ProcessRepository : IProcessRepository
    {
        //현재 검사 기준값 가져오기
        public async Task<long> NowThreshold(string selectedProcessName, string selectedTestName)
        {
            using FinalDbContext db = new();

            //공정 이름에 따라 검사 구분하기
            if (selectedProcessName == "Mix")
            {
                selectedTestName = selectedTestName + " 입고";
            }
            else if (selectedProcessName == "Pack")
            {
                selectedTestName = selectedTestName + " 출고";
            }

            var processTestResult = await db.Checks
         .Where(p => p.Check_item == selectedTestName)
         .FirstOrDefaultAsync();

            if (processTestResult != null)
            {
                //검사 기준값 반환
                return (long)processTestResult.Check_value;
            }
            else
            {
                return 0;
            }

        }

        //검사 기준값 설정하기
        public async Task SetThreshold(string selectedProcessName, string selectedTestName, long SetValue)
        {
            using FinalDbContext db = new();

            //공정 이름에 따라 검사 구분하기
            if (selectedProcessName == "Mix")
            {
                selectedTestName = selectedTestName + " 입고";
            }
            else if (selectedProcessName == "Pack")
            {
                selectedTestName = selectedTestName + " 출고";
            }

            var processTestResult = await db.Checks
        .Where(p => p.Check_item == selectedTestName)
        .FirstOrDefaultAsync();

            if (processTestResult != null)
            {
                processTestResult.Check_value = SetValue;
                await db.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }

        }

        //공정 정보 다가져오기
        public async Task<IEnumerable<Process>> GetAllAsync()
        {
            //using FinalDbContext db = new();
            //var process = await db.Processes
            //    .Include(s => s.lot)
            //    .Include(s => s.lotHistory)
            //    .ToListAsync();
            //return process.OrderByDescending(x => x.Id).ToList();
            throw new NotImplementedException();
        }

        //검사 데이터 저장하기
        public async Task SaveTestData(long processid, long data)
        {
            using FinalDbContext db = new();

            var process = await db.Processes
          .Include(p => p.Check)
          .Where(p => p.Id == processid)
          .FirstOrDefaultAsync();

            if (process != null)
            {
                //검사 데이터 저장
                process.Check.Check_Result = data;
                //검사에 데이터 SaveChangesAsync();
                await db.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        //검사 기준값 가져오기
        public async Task<long> GetTestCheckValue(long processid, long data)
        {
            using FinalDbContext db = new();

            var process = await db.Processes
        .Where(p => p.Id == processid)
        .Include(p => p.Check)
        .FirstOrDefaultAsync();

            if (process != null)
            {
                long? checkValue = process.Check.Check_value;
                return (long)checkValue;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        //공정 id 가져오기
        public long GetProcessId(string processName)
        {
            using FinalDbContext db = new();
            var process = db.Processes.FirstOrDefault(l => l.Process_name == processName);
            return process?.Id ?? 0;
        }

        //공정상태가져오기
        public async Task<string> GetSelectedProcessStatus(string selectedProcessName)
        {
            using (FinalDbContext db = new FinalDbContext())
            {
                var process = await db.Processes
            .Where(p => p.Process_name == selectedProcessName)
            .FirstOrDefaultAsync();

                if (process != null)
                {
                    return process.Process_status.ToString();
                }
                else
                {
                    throw new Exception("그런건 없음");
                }
            }
        }

        //공정 상태 바꾸기
        public async Task<bool> IsRunningAsync(bool state, string selectedProcessName)
        {
            using FinalDbContext db = new();
            var process = await db.Processes
                .Where(p => p.Process_name == selectedProcessName)
                .FirstOrDefaultAsync();

            if (process != null)
            {
                if (state == true)
                {
                    process.Process_status = true;
                }
                else
                {
                    process.Process_status = false;
                }
                await db.SaveChangesAsync();

                return true;
            }
            else
            {
                throw new Exception("그런거 없음");
            }
        }


    }
}
