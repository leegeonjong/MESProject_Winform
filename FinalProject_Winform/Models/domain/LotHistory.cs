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
        public long LotHistoryId { get; set; } // 기본 키

        [ForeignKey("Lot")]
        public long LotId { get; set; }

        [ForeignKey("Process")]
        public long ProcessId { get; set; }

        public Lot Lot { get; set; }

        public Process Process { get; set; }

        public DateTime LotHistory_startDate { get; set; } // LOT 시작 날짜

        public DateTime LotHistory_endDate { get; set; } // LOT 종료 날짜
    }
}
