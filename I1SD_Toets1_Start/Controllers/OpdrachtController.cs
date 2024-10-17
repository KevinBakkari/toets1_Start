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

        [HttpGet]
        public IActionResult Opdracht2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Opdracht2(string naam)
        {
            if (string.IsNullOrEmpty(naam))
            {
                ViewBag.Error = "Voer een geldige naam in";
                return View();
            }

            string binaireNaam = MyFunctions.ConvertStringToBinary(naam);
            ViewBag.BinaireNaam = binaireNaam;
            ViewBag.IngevoerdeNaam = naam;
            return View();

        }
    }
}
