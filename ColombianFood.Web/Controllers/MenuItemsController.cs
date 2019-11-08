using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColombianFood.Web.Data;
using ColombianFood.Web.Models.MenuItemViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ColombianFood.Web.Controllers
{
    public class MenuItemsController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnviroment;

        [BindProperty]
        public MenuItemViewModel MenuItemVM { get; set; }

        public MenuItemsController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnviroment = hostingEnvironment;
            MenuItemVM = new MenuItemViewModel()
            {
                Category = _db.Category.ToList(),
                MenuItem = new Models.MenuItem()
            };
        }

        //GET : MenuItems
        public IActionResult Index()
        {
            return View();
        }
    }
}