using Microsoft.AspNetCore.Mvc;
using System;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht3Controller : Controller
    {
        public IActionResult Opdracht3_11()
        {
            /*
             * Maak een programma met als naam Vandaag dat informatie geeft 
             * over de huidige dag. De volgende informatie moet worden getoond:
                • Het huidige jaar
                • De huidige maand (als woord)
                • De huidige dag (als woord)
                • De hoeveelste dag van de maand het is
                • Het huidige weeknummer
                • De hoeveelste dag van het jaar het is
            */
            var today = DateTime.Today;
            int year = today.Year;
            var monthWord = today.ToString("MMMM");
            ViewBag.Year = year;
            ViewBag.Month = monthWord;


            return View();
        }
    }
}
