using FinalProject_Winform.Models.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Repositories
{
    internal interface IProcessRepository
    {
        //현재 검사 기준값 가져오기
        Task<long> NowThreshold(string selectedProcessName,string selectedTestName);

        //검사 기준값 설정하기
        Task SetThreshold(string selectedProcessName,string selectedTestName, long SetValue);

        Task<IEnumerable<Process>> GetAllAsync();

        Task<string> GetSelectedProcessStatus(string selectedProcessName);

        Task<bool> IsRunningAsync(bool state, string selectedProcess);

        long GetProcessId(string processName);
    }
}
