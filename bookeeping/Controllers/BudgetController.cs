using System;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bookeeping.Models;
using bookeeping.Data;

namespace bookeeping.Controllers
{
    [Authorize]
    public class BudgetController : Controller
    {
        private readonly AccountContext _accDbContext;

        public BudgetController(AccountContext accDbContext)
        {
            _accDbContext = accDbContext;
        }

        [HttpGet]
        public IActionResult Index(int? id)
        {
            if (id == null) return NotFound();

            var budget = _accDbContext.Budgets
                        .Where(b => b.UserID == (int)id)
                        .OrderByDescending(j => j.Period)
                        .ToList();

            return View(budget);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id, DateTime date)
        {
            if (id == null) return NotFound();

            var budget = await _accDbContext.Budgets
                         .Include(b => b.Users)
                         .FirstOrDefaultAsync(d => d.Period.Month == date.Month & d.UserID == (int)id);

            return View(budget);
        }

        [HttpGet]
        public IActionResult SetBudget(int? id)
        {
            if (id == null) return NotFound();

            var user = _accDbContext.Users
                       .FirstOrDefault(u => u.Id == (int)id);

            if (user != null)
            {
                Budget budget = new Budget{ UserID = (int)id };
                return View(budget);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetBudget(Budget budget)
        {
            if (ModelState.IsValid)
            {
                _accDbContext.Budgets.Add(budget);

                await _accDbContext.SaveChangesAsync();

                return RedirectToAction("Index", new { id = budget.UserID});
            }

            return View(budget);
        }
    }
}