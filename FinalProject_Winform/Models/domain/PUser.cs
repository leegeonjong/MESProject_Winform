using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Winform.Models.domain
{
    [Table("PUser")]
    public class PUser
    {
        public long Id { get; set; }

        public string PUser_id { get; set; }  // 유저 아이디

        public string PUser_password { get; set; } // 유저 패스워드

        public string PUser_name { get; set; } // 유저 이름

        public string PUser_phoneNum { get; set; } // 유저 핸드폰번호

    }
}
