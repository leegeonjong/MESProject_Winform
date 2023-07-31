using FinalProject_Winform.Data;
using FinalProject_Winform.Models.domain;
using Microsoft.EntityFrameworkCore;
using Process = FinalProject_Winform.Models.domain.Process;

namespace FinalProject_Winform.Repositories
{
    public class ProcessRepository : IProcessRepository
    {
        //현재 허용범위 값 가져오기 
        public async Task<long> NowTolerance(string selectedProcessName, string selectedTestName)
        {
            using FinalDbContext db = new();

            selectedTestName = GetTestItemName(selectedProcessName, selectedTestName);

            var processTestResult = await GetTestResultByNameAsync(db, selectedTestName);

            if (processTestResult != null)
            {
                //허용범위 값 반환
                return (long)processTestResult.Check_Tolerance;
            }
            else
            {
                return 0;
            }
        }
        public async Task<long> GetTestToleranceValue(long processid, long data)
        {
            using FinalDbContext db = new();

            var process = await db.Processes
            .Where(p => p.Id == processid)
            .Include(p => p.Check)
            .FirstOrDefaultAsync();

            if (process != null)
            {
                long? CheckTolerance = process.Check.Check_Tolerance;
                return (long)CheckTolerance;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        //현재 검사 기준값 가져오기
        public async Task<long> NowCheckValue(string selectedProcessName, string selectedTestName)
        {
            using FinalDbContext db = new();

            selectedTestName = GetTestItemName(selectedProcessName, selectedTestName);

            var processTestResult = await GetTestResultByNameAsync(db, selectedTestName);

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


        //검사 기준값 설정하기
        public async Task SetThreshold(string selectedProcessName, string selectedTestName, long SetValue)
        {
            using FinalDbContext db = new();

            selectedTestName = GetTestItemName(selectedProcessName, selectedTestName);

             var processTestResult = await GetTestResultByNameAsync(db, selectedTestName);

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

        //허용범위 값 설정하기
        public async Task SetTolerance(string selectedProcessName, string selectedTestName, long SetTolerance)
        {
            using FinalDbContext db = new();

            selectedTestName = GetTestItemName(selectedProcessName, selectedTestName);

            var processTestResult = await db.Checks
            .Where(p => p.Check_item == selectedTestName)
            .FirstOrDefaultAsync();

            if (processTestResult != null)
            {
                processTestResult.Check_Tolerance = SetTolerance;
                await db.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
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
        public async Task IsRunningAsync(bool state, string selectedProcessName)
        {
            using FinalDbContext db = new();
            var process = await db.Processes
                .Where(p => p.Process_name == selectedProcessName)
                .FirstOrDefaultAsync();

            if (process != null)
            {
                if (state == true)
                {
                    process.Process_status = false;
                }
                else
                {
                    process.Process_status = true;
                }
                await db.SaveChangesAsync();

              
            }
            else
            {
                throw new Exception("그런거 없음");
            }
        }

        //검사 구분하기
        private string GetTestItemName(string selectedProcessName, string selectedTestName)
        {
            if (selectedProcessName == "Mix")
            {
                return selectedTestName + " 입고";
            }
            else if (selectedProcessName == "Pack")
            {
                return selectedTestName + " 출고";
            }

            // 예외 처리를 추가할 수도 있습니다.
            return selectedTestName;
        }

        //검사 이름과 같은 값 가져오기
        private async Task<Check> GetTestResultByNameAsync(FinalDbContext db, string selectedTestName)
        {
            return await db.Checks
                .Where(p => p.Check_item == selectedTestName)
                .FirstOrDefaultAsync();
        }

    }
}
