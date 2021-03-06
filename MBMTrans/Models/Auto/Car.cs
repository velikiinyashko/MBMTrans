﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBMTrans.Models.Auto
{
    public class Car
    {
        public int Id { get; set; }
        
        
        public Driver Driver { get; set; }

        public int? ManufactureId { get; set; }
        public Manufacture Manufacture { get; set; }

        public int? ModelId { get; set; }
        public Model Model { get; set; }

        public int? ColorId { get; set; }
        public Color Color { get; set; }
    }
}
