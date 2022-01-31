using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Utility;
using System;
using System.Globalization;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht3Controller : Controller
    {
        public IActionResult Opdracht3_1(string voornaam = ""
            , string tussenvoegsels = ""
            , string achternaam = "")
        {

            /*
                Maak een programma dat de gebruiker vraagt naar de volgende gegevens:
                Voornaam
                Tussenvoegsels
                Achternaam
                Vervolgens moet worden weergegeven wat de totale lengte van de naam is.
                Spaties moeten niet worden meegeteld.
            */

            // Maak een nieuwe string aan waarin de 3 gegevens aan elkaar worden
            // vastgeplakt
            var naam = voornaam +tussenvoegsels + achternaam;
            // Vervang alle spaties door een lege string
            naam = naam.Replace(" ", "");
            // Bepaal de lengte van de string en sla deze op in de viewbag
            ViewBag.lengte = naam.Length;


            return View();
        }

        public IActionResult Opdracht3_2(DateTime? birthDateWoman , DateTime? birthDateMan)
        {
            /*
            Maak een programma dat het leeftijdsverschil in dagen berekent 
            tussen twee echtgenoten.
            Het programma vraagt eerst om de geboortedatum van de vrouw 
            en daarna om de geboortedatum van de man. 
            Gebruik de functie voor de absolute waarde om ervoor te zorgen 
            dat altijd een positief getal wordt weergegeven.
            */
            if(birthDateWoman != null && birthDateMan != null)
            {
                var daysBetween = ((DateTime)birthDateMan).Subtract((DateTime)birthDateWoman).Days;
                ViewBag.DaysBetween = Math.Abs(daysBetween);    
            }
            return View();
        }

        public IActionResult Opdracht3_11()
        {
            /*
                Maak een programma met als naam Vandaag dat informatie geeft over de huidige dag. De volgende informatie moet worden getoond:
                • Het huidige jaar
                • De huidige maand (als woord)
                • De huidige dag (als woord)
                • De hoeveelste dag van de maand het is
                • Het huidige weeknummer
                • De hoeveelste dag van het jaar het is

             */
            var today = DateTime.Today;
            ViewData["today"] = today.ToLongDateString();
            ViewData["year"] = today.Year;
            ViewData["month"] = today.ToString("MMMM");
            ViewData["day"] = today.ToString("dddd");
            ViewData["daynumber"] = today.Day.ToString();
            ViewData["weeknumber"] = today.Weeknumber();
            ViewData["dayofyear"] = today.DayOfYear.ToString();
            return View();
        }

        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.GetCultureInfo("nl").Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
