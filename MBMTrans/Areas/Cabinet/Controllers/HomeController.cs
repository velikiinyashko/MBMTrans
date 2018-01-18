using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MBMTrans.Areas.Cabinet.Models;
using MBMTrans.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MBMTrans.Areas.Cabinet.Controllers
{
    [Area("Cabinet")]
    [Authorize]
    public class HomeController : Controller
    {
        private BaseContext _context;

        public HomeController(BaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}