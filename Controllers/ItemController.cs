using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JulyActivity.Data;
using Microsoft.AspNetCore.Mvc;

namespace JulyActivity.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
