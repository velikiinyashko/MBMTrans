using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBMTrans.Models.Auto
{
    public class Manufacture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Model> Models { get; set; }
        public List<Car> Cars { get; set; }

        public Manufacture()
        {
            Models = new List<Model>();
            Cars = new List<Car>();
        }
    }
}
