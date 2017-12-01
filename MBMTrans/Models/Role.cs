using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBMTrans.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Account> Accounts { get; set; }

        public Role()
        {
            Accounts = new List<Account>();
        }
    }
}
