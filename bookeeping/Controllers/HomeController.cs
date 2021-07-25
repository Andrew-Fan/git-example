using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using bookeeping.Models;
using bookeeping.Data;

namespace bookeeping.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountContext _Acc_context;
        public HomeController(AccountContext Acc_context)
        {
            _Acc_context = Acc_context;
        }

        //首頁
        public async Task<IActionResult> Index()
        {
            var user_list = await _Acc_context.Users.ToListAsync();

            return View(user_list);
        }

        
        // 建立新使用者
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public IActionResult Create()
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _Acc_context.Users.Add(user);
        //         _Acc_context.SaveChanges();

        //         return RedirectToAction("Index");
        //     }

        //     return View();
        // }

        //刪除使用者
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var user = _Acc_context.Users.Find(id);

            if (user != null)
            {
                _Acc_context.Users.Remove(user);
                _Acc_context.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
