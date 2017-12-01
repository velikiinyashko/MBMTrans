using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBMTrans.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public decimal Symmary { get; set; }

        public int? TariffId { get; set; }
        public Tariff Tariff { get; set; }

        public int? AccountId { get; set; }
        public Account Account { get; set; }
    }
}
