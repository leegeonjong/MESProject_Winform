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
        //검사 기준값 설정
        Task<long> SetThreshold(string selectedProcessName, string selectedTestName);

        Task<IEnumerable<Process>> GetAllAsync();

        Task<string> GetSelectedProcessStatus(string selectedProcessName);

        Task<bool> IsRunningAsync(bool state, string selectedProcess);

        long GetProcessId(string processName);
    }
}
