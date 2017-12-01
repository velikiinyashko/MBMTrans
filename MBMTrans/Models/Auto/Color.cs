using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBMTrans.Models.Auto
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public Color()
        {
            Cars = new List<Car>();
        }
    }
}
