using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBMTrans.Models.Auto;

namespace MBMTrans.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Verificated { get; set; }
        public string Token { get; set; }

        public List<Order> Orders { get; set; }
        public List<Driver> Drivers { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public Account()
        {
            Orders = new List<Order>();
            Drivers = new List<Driver>();
        }
    }
}
