using I1SD_Toets1_Start;
using Microsoft.AspNetCore.Mvc;

namespace Toets1_Start.Controllers
{
    public class OpdrachtController : Controller
    {
        public IActionResult Opdracht1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht1(int getal)
        {
            ViewBag.Naam = "Kevin Bakkari";
            // geleerd van marcel
            ViewBag.Getal = getal;
            // dit boven
            string result = MyFunctions.GenereerGetallenreeks(getal);
            ViewBag.Result = result;
            return View();
        }

        public IActionResult Opdracht2()
        {
            // Hier komt jouw uitwerking van opdracht 2
            ViewBag.Naam = "Kevin Bakkari";
            return Content("Welkom bij deze ASP-NET / C# toets");
        }
    }
}
