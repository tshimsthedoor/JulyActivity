using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JulyActivity.Data;
using JulyActivity.Models;
using Microsoft.AspNetCore.Mvc;

namespace JulyActivity.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> objeList = _db.Expenses;
            return View(objeList);
        }

        // Get Create
        public IActionResult Create()
        {

            return View();
        }

        // Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);

        } // Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Remove(id);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(id);

        }
    }

}
