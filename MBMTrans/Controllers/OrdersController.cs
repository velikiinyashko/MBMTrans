using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MBMTrans.ViewModels;
using MBMTrans.Models;

namespace MBMTrans.Controllers
{
    public class OrdersController : Controller
    {
        private BaseContext _context;

        public OrdersController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string Name)
        {
            if (Name != null) {
                if (User.Identity.Name == Name) {
                    Account account = await _context.Accounts.FirstOrDefaultAsync(u => u.Name == Name);
                    if(account != null)
                    {
                        await _context.Orders.Where(o => o.AccountId == account.Id).LoadAsync();
                        return View(account.Orders);
                    }
                    return View();
                }
                return NotFound();
            }
            return NotFound();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int? Id)
        {
            return View();
        }
    }
}