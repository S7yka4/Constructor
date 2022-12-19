using Constructor.Storage.Managers.Devices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor.Controllers
{
    public class DbChangeController : Controller
    {
        private readonly IDevicesManager Manager;

        public DbChangeController(IDevicesManager _DevicesManager)
        {
            Manager = _DevicesManager;
        }

        [HttpGet]
        public IActionResult Output()
        {
            return View(Manager.Devices);
        }
        [HttpGet]
        public IActionResult ErrorPage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddToDb()
        {
            return View();
        }
    }
}
