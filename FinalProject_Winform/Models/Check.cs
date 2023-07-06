using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models
{
    [Table("Check")]
    public class Check
    {
        public long Id { get; set; } // PK

        public Process? Process { get; set; }

        public string Check_item { get; set; } // 검사 항목

        public string Check_value { get; set; } // 검사 기준 값
    }
}
