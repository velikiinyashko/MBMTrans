using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MBMTrans.Areas.Cabinet.Controllers
{
    public class CatalogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}