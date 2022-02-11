using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RskExtensions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht4Controller : Controller
    {
        public IActionResult Opdracht4_1(double? getal1 = null, double? getal2 = null)
        {
            /*
             * Lees twee getallen in en geef aan welk van beide getallen 
             * het grootste is. 
             * Als beide getallen hetzelfde zijn dient dat ook weergegeven 
             * te worden. De uitvoer is dus één van de volgende:
                • Het eerste getal is het grootste
                • Het tweede getal is het grootste
                • De getallen zijn gelijk aan elkaar
             */
            if (getal1 != null && getal2 != null)
            {
                if (getal1 == getal2)
                {
                    ViewBag.Result = "De getallen zijn gelijk";
                }
                else if (getal1 < getal2)
                    ViewBag.Result = "Getal 2 is het grootst";
                else
                    ViewBag.Result = "Getal 1 is het grootst";
                ViewBag.getal1 = getal1;
                ViewBag.getal2 = getal2;
            }
            return View();
        }

        public IActionResult Opdracht4_2(double? getal1 = null, 
            double? getal2 = null, double? getal3 = null)
        {
            /*
             Schrijf een programma dat 3 getallen inleest. 
             Als de eerste twee beide groter zijn dan het derde 
             dient als uitvoer getoond te worden:
                Het derde getal is het kleinste van de drie.
                Als dat niet zo is moet als tekst verschijnen:
                Het derde getal is niet het kleinste van de drie.
             */
            if (getal1 != null && getal2 != null && getal3 != null)
            {
                if (getal3 < getal2 && getal3 < getal1)
                {
                    ViewBag.Result = "Het derde getal is het kleinste van de drie";
                }
                else
                {
                    ViewBag.Result = "Het derde getal is niet het kleinste van de drie";
                }
                ViewBag.getal1 = getal1;
                ViewBag.getal2 = getal2;
                ViewBag.getal3 = getal3;
            }
            return View();
        }

        public IActionResult Opdracht4_8(string language)
        {
            List<SelectListItem> languages = new List<SelectListItem>();
            languages.Add(new SelectListItem("Nederlands","NL"));
            languages.Add(new SelectListItem("Duits","GE"));
            languages.Add(new SelectListItem("Engels","GB"));
            languages.Add(new SelectListItem("Frans", "FR"));
            languages.Add(new SelectListItem("Spaans", "SP"));
            languages.Add(new SelectListItem("Zweeds","SV"));
            foreach(SelectListItem value in languages)
            {
                if(value.Value == language)
                {
                    value.Selected = true;
                }
            }
            if(language != "")
            {
                var message = "";
                switch(language)
                {
                    case "NL":
                        message = "De huidige maand is " + DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("nk-NL"));
                        break;
                    case "GE":
                        message = "Der aktuelle Monat ist " + DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("de-DE"));
                        break;
                    case "GB":
                        message = "The current month is " + DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("en-EN"));
                        break;
                    case "FR":
                        message = "Le mois en cours est " + DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("fr-FR"));
                        break;
                    case "SP":
                        message = "El mes actual es " + DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("es-ES"));
                        break;
                    case "SV":
                        message = "Den aktuella månaden är " + DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("sv-SE"));
                        break;
                }
                ViewBag.Message = message;
            }
            ViewBag.Selected = language;
            ViewBag.Languages = languages;

            return View();
        }
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
