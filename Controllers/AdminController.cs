using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext Database;

        public AdminController(ApplicationDbContext database)
        {
            this.Database = database;
        }

        public IActionResult Index()
        {
            return Content("Chegou adm");
        }
    }
}