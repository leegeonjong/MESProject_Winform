using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models.domain
{
    [Table("LotHistory")]
    public class LotHistory
    {
        [Key]
        public long Id { get; set; } // 기본 키

        [ForeignKey("Lot")]
        public long LotId { get; set; }

        [ForeignKey("Process")]
        public long ProcessId { get; set; }

        [ForeignKey("Check")]
        public long CheckId { get; set; }
        public Lot Lot { get; set; }

        public Process Process { get; set; }

        public string? CheckResult { get; set; } //Lot 검사 이력

        public DateTime? LotHistory_Date { get; set; } // LOT 시작 날짜

        public string? LotHistory_status { get; set; } // LOT mix end
    }
}
