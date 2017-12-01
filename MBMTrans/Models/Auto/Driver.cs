using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBMTrans.Models;

namespace MBMTrans.Models.Auto
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int? CarId { get; set; }
        public Car Car { get; set; }

        public int? AccountId { get; set; }
        public Account Account { get; set; }
    }
}
