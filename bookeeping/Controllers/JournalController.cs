using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using bookeeping.Data;
using bookeeping.Models;

namespace bookeeping.Controllers
{
    [Authorize]
    public class JournalController : Controller
    {
        private readonly AccountContext _AccDbContext;
        private readonly IComputation _Computation;

        public JournalController(AccountContext AccDbContext, IComputation Computation)
        {
            _AccDbContext = AccDbContext;
            _Computation = Computation;
        }

        [HttpGet]
        public IActionResult Index(int? id)
        {
            if (id == null) return NotFound();

            var user = _AccDbContext.Users
                       .FirstOrDefault(u => u.Id == (int)id);

            return View(user);
        }

        [HttpGet]
        public IActionResult Add_Expense(int? id)
        {
            if (id == null) return NotFound();
            var user = _AccDbContext.Users
                       .FirstOrDefault(u => u.Id == (int)id);

            if (user != null)
            {
                Journal journal = new Journal{ UserID = (int)id };
                return View(journal);
            }
            
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add_Expense(
                [Bind("UserID, Date, Type, Category, AccountingTitle, Description, Amount")]Journal journal)
        {
            if (ModelState.IsValid)
            {
                var user = _AccDbContext.Users
                           .FirstOrDefault(u => u.Id == journal.UserID);

                user.Balance -= journal.Amount;

                _AccDbContext.Users.Update(user);
                _AccDbContext.Journals.Add(journal);
                await _AccDbContext.SaveChangesAsync();

                return RedirectToAction("Index", new { id = journal.UserID });
            }

            return View(journal);
        }

        [HttpGet]
        public IActionResult Add_Revenue(int? id)
        {
            if (id == null) return NotFound();
            var user = _AccDbContext.Users
                       .FirstOrDefault(u => u.Id == (int)id);

            if (user != null)
            {
                Journal journal = new Journal{ UserID = (int)id };
                return View(journal);
            }
            
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add_Revenue(
                [Bind("UserID, Date, Type, Category, AccountingTitle, Description, Amount")]Journal journal)
        {
            if (ModelState.IsValid)
            {
                var user = _AccDbContext.Users
                           .FirstOrDefault(u => u.Id == journal.UserID);

                user.Balance += journal.Amount;

                _AccDbContext.Users.Update(user);
                _AccDbContext.Journals.Add(journal);
                await _AccDbContext.SaveChangesAsync();

                return RedirectToAction("Index", new { id = journal.UserID });
            }

            return View(journal);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var journal = await _AccDbContext.Journals
                          .Include(j => j.Users)
                          .OrderByDescending(j => j.Date)
                          .Where(u => u.Users.Id == (int)id)
                          .ToListAsync();

            return journal.Any() ? View(journal) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id, int? jouid)
        {
            if (id == null || jouid == null) return NotFound();

            var journal = await _AccDbContext.Journals
                          .Include(j => j.Users)
                          .Where(u => u.Users.Id == (int)id)
                          .FirstOrDefaultAsync(j => j.JournalID == jouid);

            return journal.Type == 0 ? View("Edit_Rev", journal) : View("Edit_Exp", journal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Journal journal)
        {
            if (ModelState.IsValid)
            {
                var journal_old = await _AccDbContext.Journals
                               .Include(j => j.Users)
                               .Where(u => u.Users.Id == journal.UserID)
                               .FirstOrDefaultAsync(j => j.JournalID == journal.JournalID);

                decimal edit = _Computation.Edit(journal_old, journal);
                _Computation.Edit_Data(journal_old, journal);

                journal_old.Users.Balance += edit;

                _AccDbContext.Journals.Update(journal_old);
                _AccDbContext.Users.Update(journal_old.Users);
                await _AccDbContext.SaveChangesAsync();

                return RedirectToAction("Details", new { id = journal.UserID });
            }

            return View(journal);
        }
    }
}