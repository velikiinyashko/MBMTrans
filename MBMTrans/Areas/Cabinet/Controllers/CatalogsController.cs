using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MBMTrans.Models;

namespace MBMTrans.Areas.Cabinet.Controllers
{
    [Authorize]
    [Area("Cabinet")]
    public class CatalogsController : Controller
    {
        private BaseContext _context;

        public CatalogsController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Catalogs.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Catalog catalog)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}