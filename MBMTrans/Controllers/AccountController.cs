using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using MBMTrans.ViewModels;
using MBMTrans.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace MBMTrans.Controllers
{
    public class AccountController : Controller
    {
        private BaseContext _context;

        public AccountController(BaseContext context)
        {
            _context = context;
            DatabaseInitialize();
        }

        private void DatabaseInitialize()
        {
            if (!_context.Roles.Any())
            {
                string AdminRoleName = "Admin";
                string UserRoleName = "User";
                string DriverRoleName = "Driver";
                string AdminCompanyRoleName = "AdminCompany";
                string UserCompanyRoleName = "UserCompany";

                Role AdminRole = new Role { Name = AdminRoleName };
                Role UserRole = new Role { Name = UserRoleName };
                Role DriverRole = new Role { Name = DriverRoleName };
                Role AdminCompanyRole = new Role { Name = AdminCompanyRoleName };
                Role UserCompanyRole = new Role { Name = UserCompanyRoleName };

                _context.Roles.Add(AdminRole);
                _context.Roles.Add(UserRole);
                _context.Roles.Add(DriverRole);
                _context.Roles.Add(AdminCompanyRole);
                _context.Roles.Add(UserCompanyRole);

                _context.Accounts.Add(new Account { Login = "Admin", Password = "Admin", Role = AdminRole, Name = "Admin", Email = "admin@sibitproject.ru" });
                _context.SaveChanges();
            }
        }

        [Authorize]
        public async Task<IActionResult> Index(string Name)
        {
            Account account = await _context.Accounts
                .Include(r => r.Role)
                .FirstOrDefaultAsync(u => u.Login == Name);
            if (account != null)
            {
                return View(account);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = await _context.Accounts
                    .Include(r => r.Role)
                    .FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if(account != null)
                {
                    await Authenticate(account);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Не верные данные проверьте логин и(или) рароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = await _context.Accounts.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (account == null)
                {
                    account = new Account { Login = model.Login, Password = model.Password, Email = model.Email, Phone = model.Phone };
                    Role role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "User");
                    if (role != null)
                        account.Role = role;

                    _context.Accounts.Add(account);

                    await _context.SaveChangesAsync();

                    await Authenticate(account);

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Проверьте введеные данные");
            }
            return View(model);

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        private async Task Authenticate(Account user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}