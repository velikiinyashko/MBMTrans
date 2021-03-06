﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MBMTrans.Models;
using Microsoft.EntityFrameworkCore;

namespace MBMTrans.Controllers
{
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            return View();
        }

        public async Task<IActionResult> Catalogs()
        {
            List<Catalog> catalog = await _context.Catalogs.Include(Mft => Mft.Manufacture)
                .Include(Mod => Mod.Model)
                .Include(Color => Color.Color)
                .ToListAsync();
            return View(catalog);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public decimal Summary(JsonObject json, decimal Prices)
        {
            decimal price = 0;



            return price;
        }

        public IActionResult Maps()
        {
            return PartialView("_Maps");
        }

        public IActionResult Menu()
        {
            return PartialView("_Menu");
        }

        public IActionResult Singin()
        {
            return PartialView("_Singin");
        }

        public IActionResult Order()
        {
            return PartialView("_Order");
        }

        public IActionResult Carusel()
        {
            return PartialView("_Carusel");
        }
    }
}
