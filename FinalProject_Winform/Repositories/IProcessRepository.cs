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
        //현재 허용 범위 값 가져오기
        Task<long> NowTolerance(string selectedProcessName, string selectedTestName);
        //현재 검사 기준값 가져오기
        Task<long> NowCheckValue(string selectedProcessName, string selectedTestName);

        //검사 허용범위 설정하기
        Task SetTolerance(string selectedProcessName, string selectedTestName, long SetValue);

        //검사 기준값 설정하기
        Task SetThreshold(string selectedProcessName, string selectedTestName, long SetValue);

        //검사 값 저장하기
        Task SaveTestData(long processid, long data);
        //현재 검사 기준값 가져오기
        Task<long> GetTestCheckValue(long processid, long data);
        //현재 허용 범위 값 가져오기
        Task<long> GetTestToleranceValue(long processid, long data);
        Task<string> GetSelectedProcessStatus(string selectedProcessName);

        Task<bool> IsRunningAsync(bool state, string selectedProcess);

        long GetProcessId(string processName);
    }
}
