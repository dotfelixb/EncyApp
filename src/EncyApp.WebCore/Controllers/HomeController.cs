// Copyright (c) 2020 dotfelixb
// See License in the project root for license information.

namespace EncyApp.WebCore.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
