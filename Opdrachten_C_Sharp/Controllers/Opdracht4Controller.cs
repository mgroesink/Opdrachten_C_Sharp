using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Utility;
using System;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht4Controller : Controller
    {
        public IActionResult Opdracht4_16()
        {
            /*
                Maak een programma met als naam Vandaag dat informatie geeft over de huidige dag. De volgende informatie moet worden getoond:
                • Het huidige jaar
                • De huidige maand (als woord)
                • De huidige dag (als woord)
                • De hoeveelste dag van de maand het is
                • Het huidige weeknummer
                • De hoeveelste dag van het jaar het is
                • Of het huidige jaar is schrikkeljaar is
                • Of de huidige dag een werkdag is of een dag in het weekend

                Geef alle informatie weer in rood op een gele achtergrond als
                de huidige dag in het weekend valt 


             */
            var today = DateTime.Today;
            ViewData["today"] = today.ToLongDateString();
            ViewData["year"] = today.Year;
            ViewData["month"] = today.ToString("MMMM");
            ViewData["day"] = today.ToString("dddd");
            ViewData["daynumber"] = today.Day.ToString();
            ViewData["weeknumber"] = today.Weeknumber();
            ViewData["dayofyear"] = today.DayOfYear.ToString();
            ViewData["weekend"] = today.DayOfWeek ==
                DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday;
            ViewData["leapyear"] = DateTime.IsLeapYear(today.Year);
            return View();
        }
    }
}
