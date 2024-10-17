using Microsoft.AspNetCore.Mvc;

namespace Toets1_Start.Controllers
{
    public class OpdrachtController : Controller
    {
        public IActionResult Opdracht1()
        {
            // Hier komt jouw uitwerking van opdracht 1
            ViewBag.Naam = "Jouw naam";
            return Content("Welkom bij deze ASP-NET / C# toets");
        }

        public IActionResult Opdracht2()
        {
            // Hier komt jouw uitwerking van opdracht 2
            ViewBag.Naam = "Jouw naam";
            return Content("Welkom bij deze ASP-NET / C# toets");
        }
    }
}
