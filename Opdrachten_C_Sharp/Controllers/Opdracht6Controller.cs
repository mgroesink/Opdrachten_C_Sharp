using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Utility;
using System;
using System.Text;

namespace Opdrachten_C_Sharp.Controllers
{
    public enum Zodiacs
    {
        Ram,
        Stier,
        Tweeling,
        Kreeft,
        Leeuw,
        Maagd,
        Weegschaal,
        Schorpioen,
        Boogschutter,
        Steenbok,
        Waterman,
        Vissen

    }
    public class Opdracht6Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Opdracht6_3(string firstName,
            DateTime? birthDate)
        {
            if (firstName != "" && birthDate != null)
            {
                var zodiac = Enum.Parse(typeof(Zodiacs), Zodiac((DateTime)birthDate));
                ViewBag.Zodiac = zodiac.ToString().ToLower();
                ViewBag.FirstName = firstName;
            }
            return View();
        }

        public IActionResult Opdracht6_7(int numberOfItems = 0)
        {
            /*
            * Schrijf een programma dat het opgegeven aantal fibonacci getallen laat zien. 
            */
            if (numberOfItems > 0)
            {
                ViewBag.Count = numberOfItems;
                long first = 0;
                long second = 1;
                var fibonacci = new StringBuilder("0<br/>1<br/>");
                for (var i = 0; i < numberOfItems - 2; i++)
                {
                    long sum = first + second;
                    fibonacci.Append(sum + "<br/>");
                    first = second;
                    second = sum;
                }
                ViewBag.Fibonacci = fibonacci.ToString().Substring(0, fibonacci.Length - 2);

            }
            return View();
        }

        public IActionResult Opdracht6_14()
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
            ViewData["weekend"] = IsWeekend(today);
            ViewData["leapyear"] = IsLeapYear(today);
            return View();
        }

        private string Zodiac(DateTime date)
        {
            Zodiacs zodiac;
            if (date.Month == 3 && date.Day >= 21 ||
                date.Month == 4 && date.Day <= 20)
            {
                zodiac = Zodiacs.Ram;
            }
            else if (date.Month == 4 && date.Day >= 21 ||
                date.Month == 5 && date.Day <= 21)
            {
                zodiac = Zodiacs.Stier;
            }
            else if (date.Month == 5 && date.Day >= 22 ||
                date.Month == 6 && date.Day <= 21)
            {
                zodiac = Zodiacs.Tweeling;
            }
            else if (date.Month == 6 && date.Day >= 22 ||
                date.Month == 7 && date.Day <= 22)
            {
                zodiac = Zodiacs.Kreeft;
            }
            else if (date.Month == 7 && date.Day >= 23 ||
                date.Month == 8 && date.Day <= 23)
            {
                zodiac = Zodiacs.Leeuw;
            }
            else if (date.Month == 8 && date.Day >= 24 ||
                date.Month == 9 && date.Day <= 22)
            {
                zodiac = Zodiacs.Maagd;
            }
            else if (date.Month == 9 && date.Day >= 23 ||
                date.Month == 10 && date.Day <= 22)
            {
                zodiac = Zodiacs.Weegschaal;
            }
            else if (date.Month == 10 && date.Day >= 23 ||
                date.Month == 11 && date.Day <= 21)
            {
                zodiac = Zodiacs.Schorpioen;
            }
            else if (date.Month == 11 && date.Day >= 22 ||
                date.Month == 6 && date.Day <= 22)
            {
                zodiac = Zodiacs.Boogschutter;
            }
            else if (date.Month == 12 && date.Day >= 23 ||
                date.Month == 1 && date.Day <= 20)
            {
                zodiac = Zodiacs.Steenbok;
            }
            else if (date.Month == 1 && date.Day >= 21 ||
                date.Month == 2 && date.Day <= 19)
            {
                zodiac = Zodiacs.Waterman;
            }
            else
            {
                zodiac = Zodiacs.Vissen;
            }
            return zodiac.ToString();

        }

        private bool IsLeapYear()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }
        private bool IsLeapYear(int year)
        {
            if(year < 50)
            {
                year = int.Parse(DateTime.Now.Year.ToString().Substring(0, 2)) * 100 + year;
            }
            else if(year < 100)
            {
                year = int.Parse(DateTime.Now.Year.ToString().Substring(0, 2)) * 100 - 1 + year;
            }

            return DateTime.IsLeapYear(year);
        }

        private bool IsLeapYear(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year);
        }

        private bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek ==
                DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

    }
}
