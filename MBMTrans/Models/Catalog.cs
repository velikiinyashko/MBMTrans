using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBMTrans.Models.Auto;

namespace MBMTrans.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public string Period { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int? ManufactureId { get; set; }
        public Manufacture Manufacture { get; set; }

        public int? ModelId { get; set; }
        public Model Model { get; set; }

        public int? ColorId { get; set; }
        public Color Color { get; set; }
    }
}
