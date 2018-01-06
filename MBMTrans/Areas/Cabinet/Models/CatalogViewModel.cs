using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MBMTrans.Models;
using MBMTrans.Models.Auto;

namespace MBMTrans.Areas.Cabinet.Models
{
    public class CatalogViewModel
    {
        IEnumerable<Catalog> Catalogs { get; set; }
        IEnumerable<Manufacture> Manufactures { get; set; }
        IEnumerable<Car> Cars { get; set; }

    }
}
