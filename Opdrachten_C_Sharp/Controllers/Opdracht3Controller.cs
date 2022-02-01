using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Utility;
using System;
using System.Collections.Generic;
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
            var naam = voornaam + tussenvoegsels + achternaam;
            // Vervang alle spaties door een lege string
            naam = naam.Replace(" ", "");
            // Bepaal de lengte van de string en sla deze op in de viewbag
            ViewBag.lengte = naam.Length;


            return View();
        }

        public IActionResult Opdracht3_2(DateTime? birthDateWoman, DateTime? birthDateMan)
        {
            /*
            Maak een programma dat het leeftijdsverschil in dagen berekent 
            tussen twee echtgenoten.
            Het programma vraagt eerst om de geboortedatum van de vrouw 
            en daarna om de geboortedatum van de man. 
            Gebruik de functie voor de absolute waarde om ervoor te zorgen 
            dat altijd een positief getal wordt weergegeven.
            */
            if (birthDateWoman != null && birthDateMan != null)
            {
                var daysBetween = ((DateTime)birthDateMan).Subtract((DateTime)birthDateWoman).Days;
                ViewBag.DaysBetween = Math.Abs(daysBetween);
            }
            return View();
        }

        public IActionResult Opdracht3_3(int width , int height , int length)
        {
            /*
             * Maak een programma dat de inhoud van een kubus berekent. 
             * De gebruiker voert hoogte, lengte en breedte in en de inhoud 
             * wordt weergegeven met 2 decimalen.
             */
            var volume = width * height * length;
            ViewBag.Volume = volume;
            ViewBag.Height = height;
            ViewBag.Width = width;
            ViewBag.Length = length;
            return View();
        }

        public IActionResult Opdracht3_4(double euro = 0)
        {
            /*
             * Maak een programma dat een geldbedrag in euro’s omrekent naar 5 door jou te 
             * kiezen valuta. Het bedrag in euro’s moet door de gebruiker worden ingevoerd. 
             * Gebruik de koersen die gelden op de dag dat de opdracht wordt gemaakt.
             */

            var currencies = new Dictionary<string , double>();
            currencies["Amerikaanse dollar"] = euro * 1.13;
            currencies["Zweedse kroon"] = euro * 10.44;
            currencies["Zuid-Afrikaanse rand"] = euro * 17.16;
            currencies["Antilliaanse gulden"] = euro * 2;
            currencies["Braziliaanse real"] = euro * 5.95;
            ViewBag.Currency = currencies;
            ViewBag.Money = euro;
            return View();
        }

        public IActionResult Opdracht3_5(double length , double width)
        {
            /*
             * Maak een programma dat berekent hoeveel het stallen van een camper kost.
             * De verhuurder rekent een prijs van 1,50 euro per vierkante meter 
             * per maand. 
             * Als een contract voor minimaal 3 jaar wordt aangegaan wordt 
             * een korting van 10% van het bedrag verstrekt en als een contract 
             * van minimaal 2 jaar wordt aangegaan bedraagt de korting 5%.
             * Als invoer wordt de breedte en de lengte van een camper opgegeven 
             * en als uitvoer moet worden getoond wat de kosten zijn 
             * voor 1 jaar stalling, voor 2 jaar stalling en voor 3 jaar stalling.
             */
            var squarem2 = length * width;
            if(squarem2 > 0)
            {
                ViewBag.Width = width;
                ViewBag.Length = length;
                ViewBag.Cost1 = 12 * 1.5 * squarem2;
                ViewBag.Cost2 = 24 * 1.5 * squarem2 * .95; // 5% discount
                ViewBag.Cost3 = 36 * 1.5 * squarem2 * .9; // 10% discount
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
