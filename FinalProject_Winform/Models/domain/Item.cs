using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models.domain
{
    [Table("Item")]
    public class Item
    {
        public long Id { get; set; }    // PK
        public string Item_name { get; set; } // 재고 이름 (ex : 밀가루)

        public string Item_unit { get; set; } // 단위 (ex : kg)

        public string Item_barcode { get; set; } // 바코드 

        public string Item_type { get; set; }   // 원재료 , 완제품

        public long Item_amount { get; set; } // 총 수량

        public long Item_baseLine { get; set; }  // 적정 재고량
    }
}
