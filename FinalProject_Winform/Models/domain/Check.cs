using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models.domain
{
    [Table("Check")]
    public class Check
    {
        public long Id { get; set; } // PK

        public string Check_item { get; set; } // 검사 항목

        public long? Check_value { get; set; } // 검사 기준 값

        public long? Check_Result { get; set; } // 검사 결과 값 
    }
}
