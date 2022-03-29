using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext Database;

        public UserController(ApplicationDbContext database)
        {
            this.Database = database;
        }

        public IActionResult Index()
        {
            return Content("Chegou user");
        }
    }
}