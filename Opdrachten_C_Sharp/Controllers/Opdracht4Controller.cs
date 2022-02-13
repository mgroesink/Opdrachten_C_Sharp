using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RskExtensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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

        public IActionResult Opdracht4_3(int? color)
        {
            /*
            Lees een getal in: 1, 2, 3 of 4. 
            Als geen geldig getal wordt ingevoerd moet als melding verschijnen: 
            Geen geldige waarde. Alleen 1, 2, 3 of 4 is toegestaan.
            Als wel een geldig getal is ingevoerd moet als melding verschijnen:
            • Bij 1: Klaveren
            • Bij 2: Ruiten
            • Bij 3: Harten
            • Bij 4: Schoppen
            */
            switch (color)
            {
                case null:
                    break;
                case 1:
                    ViewBag.Result = "Klaveren";
                    break;
                case 2:
                    ViewBag.Result = "Ruiten";
                    break;
                case 3:
                    ViewBag.Result = "Harten";
                    break;
                case 4:
                    ViewBag.Result = "Schoppen";
                    break;
                default:
                    ViewBag.Result = "Geen geldige waarde. Alleen 1, 2, 3 of 4 is toegestaan";
                    break;
            }
            ViewBag.color = color;
            return View();
        }

        public IActionResult Opdracht4_4(int? number1 , int? number2)
        {
            /*
            Lees 2 getallen in. 
            Bepaal en toon of het tweede getal een veelvoud is van het eerste getal. 
            24 is een veelvoud van 3, want als je 24 deelt door 3 houd je niets over. 
            Maar 26 is geen veelvoud van 5, want als je 26 deelt door 5 
            houd je een restant van 1 over.
            */
            if(number1!= null && number2 != null)
            {
                ViewBag.Result = number1 % number2 == 0 ?
                    $"{number1} is een veelvoud van {number2}" :
                    $"{number1} is geen veelvoud van {number2}";
                ViewBag.Number1 = number1;
                ViewBag.Number2 = number2;
            }
            return View();
        }

        public IActionResult Opdracht4_6(int hours, int age, int failures)
        {
            /*
            Een metaaldraaibank wordt aan het eind van het jaar vervangen door een nieuwe als aan één of meer van de volgende voorwaarden is voldaan:
                • Aantal werkuren is meer dan 10.000
                • Het apparaat is 7 jaar oud of meer
                • Het aantal storingen per jaar is meer dan 25
            Lees de benodigde gegevens in en toon vervolgens of de draaibank vervangen moet worden of niet.

             */
            if (hours > 10000 || age >= 7 || failures > 25)
            {
                ViewBag.Message = "Machine moet worden vervangen";
            }
            else if (hours > 0)
            {
                ViewBag.Message = "Machine hoeft nog niet te worden vervangen";
            }
            ViewData["hours"] = hours;
            ViewData["age"] = age;
            ViewData["failures"] = failures;
            return View();
        }
        public IActionResult Opdracht4_7()
        {
            /*
            Maak een programma dat de gebruiker begroet op basis van het tijdstip van de dag en het soort dag.Hieronder zie je enkele voorbeelden:

            Als het tussen 00:00 en 12.00 uur is op een doordeweekse dag 
            dient de uitvoer te zijn:
            Goedemorgen het is vandaag een werkdag
            Als het tussen 12:00 en 18.00 uur is op een zaterdag of zondag 
            dient de uitvoer te zijn:
                Goedemiddag het is vandaag weekend
            Als het tussen 18:00 en 24.00 uur is op een doordeweekse dag 
            dient de uitvoer te zijn:
                Goedenavond het is vandaag een werkdag
            */
            StringBuilder message = new StringBuilder();
            DateTime now = DateTime.Now;
            if (now.Hour < 12)
            {
                message.Append("Goedemorgen");
            }
            else if (now.Hour < 18)
            {
                message.Append("Goedemiddag");
            }
            else
            {
                message.Append("Goedenavond");
            }
            message.Append(" het is vandaag ");
            if (now.DayOfWeek == DayOfWeek.Sunday ||
                now.DayOfWeek == DayOfWeek.Saturday)
            {
                message.Append(" weekend.");

            }
            else
            {
                message.Append(" een werkdag.");

            }
            ViewBag.Message = message.ToString();
            return View();

        }

        public IActionResult Opdracht4_8(string language)
        {
            List<SelectListItem> languages = new List<SelectListItem>();
            languages.Add(new SelectListItem("Nederlands", "NL"));
            languages.Add(new SelectListItem("Duits", "GE"));
            languages.Add(new SelectListItem("Engels", "GB"));
            languages.Add(new SelectListItem("Frans", "FR"));
            languages.Add(new SelectListItem("Spaans", "SP"));
            languages.Add(new SelectListItem("Zweeds", "SV"));
            foreach (SelectListItem value in languages)
            {
                if (value.Value == language)
                {
                    value.Selected = true;
                }
            }
            if (language != "")
            {
                var message = "";
                switch (language)
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
