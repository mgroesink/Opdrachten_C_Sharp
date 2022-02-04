using Microsoft.AspNetCore.Mvc;
using RskExtensions;
using System;
using System.Globalization;


namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht3Controller : Controller
    {
        public IActionResult Opdracht3_11(DateTime date)
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

            var today = date;
            int year = today.Year;
            var monthWord = today.ToString("MMMM");
            ViewBag.Year = year;
            ViewBag.Month = monthWord;
            ViewBag.Day = today.ToString("dddd");
            ViewBag.Weeknumber = today.Weeknumber();
            ViewBag.Daynumber = today.DayOfYear;
            ViewBag.LeapYear = today.IsLeapYear() ? "Ja" : "Nee"; //ternary operator
            ViewBag.Weekend = today.IsWeekend() ? "Ja" : "Nee";
            return View();
        }

        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
