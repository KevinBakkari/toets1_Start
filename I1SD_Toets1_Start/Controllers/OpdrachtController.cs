using I1SD_Toets1_Start;
using Microsoft.AspNetCore.Mvc;

namespace Toets1_Start.Controllers
{
    public class OpdrachtController : Controller
    {
        [HttpPost]
        public IActionResult Opdracht1(int getal)
        {
            ViewBag.Naam = "Kevin Bakkari";
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
