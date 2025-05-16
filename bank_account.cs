using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LTWindow_KTGK_LeNguyenMinhHoang
{
    public class bank_account
    {
        public BigInteger account_id {  get; set; }
        public string owner_name { get; set; }
        public string owner_adress { get; set; }
        public string owner_phone { get; set; }
        public double balance { get; set; }
        public string account_type { get; set; }
        public string password { get; set; }

    }
    public class transactions
    {
        public string trans_id { get; set; }
        public DateTime happened_time { get; set; }
        public string action_desc { get; set; }
        public string note { get; set; }
        public ICollection<bank_account> account_id { get; set; }
    }
}
