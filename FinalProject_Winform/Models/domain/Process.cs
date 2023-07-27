using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models.domain
{
    [Table("Process")]
    public class Process
    {
        public long Id { get; set; }

        public Check? Check { get; set; } //검사 하는 공정

        public string Process_name { get; set; } // 공정이름

        public bool Process_status { get; set; } // 공정 상태

        public bool? Process_checkRight { get; set; } // 공정 검사 통과 여부

    }
}
