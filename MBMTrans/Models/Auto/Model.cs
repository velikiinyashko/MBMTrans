using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBMTrans.Models.Auto
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ManufactureId { get; set; }
        public Manufacture Manufacture { get; set; }

        public List<Car> Cars { get; set; }

        public Model()
        {
            Cars = new List<Car>();
        }
    }
}
