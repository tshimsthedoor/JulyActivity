using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JulyActivity.Data;
using JulyActivity.Models;
using Microsoft.AspNetCore.Mvc;

namespace JulyActivity.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objeList = _db.Items;
            return View(objeList);
        } 
        
        public IActionResult Create()
        {
            
            return View();
        }
    }
}
