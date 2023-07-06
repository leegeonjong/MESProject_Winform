using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models.domain
{
    [Table("Lot")]
    public class Lot
    {
        public long Id { get; set; }  //PK

        public Item? Item { get; set; }

        public string Lot_barcode { get; set; } // LOT 바코드

        public long Lot_amount { get; set; } // LOT 수량

        public string Lot_status { get; set; }  // LOT 상태

        public bool Lot_break { get; set; } // 불량 여부

        public DateTime? Lot_regDate { get; set; }  // LOT 생성 날짜 





    }
}
