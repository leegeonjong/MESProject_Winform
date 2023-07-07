using FinalProject_Winform.Models.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Process = FinalProject_Winform.Models.domain.Process;

namespace FinalProject_Winform.Data
{
    public class FinalDbContext : DbContext
    {
        string strConn = "Server=127.0.0.1; Database=FinalDB; uid=FinalUser; pwd=1234; Encrypt=false";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder
                 .UseSqlServer(strConn)
                .LogTo(message => Debug.WriteLine(message)) // 디버그모드에서 '출력'창에 표시
                .EnableSensitiveDataLogging())
                ;
        }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<LotHistory> LotHistorys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        

    }
}


