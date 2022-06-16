using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ogrenci_Ders_Secimi_1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
