using Microsoft.AspNetCore.Mvc;
using RskExtensions;
using System;
using System.Text;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht6Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Opdracht6_1()
        {
            /*
             * Schrijf een methode die als tekst retourneert
             * Hallo allemaal wat leuk dat jullie er zijn
             */

            ViewBag.Text = StaticMethods.LuizenMoeder();
            return View();
        }

        public IActionResult Opdracht6_3(string firstName,
            DateTime? birthDate)
        {
            if (firstName != "" && birthDate != null)
            {
                var zodiac = Enum.Parse(typeof(Zodiacs), StaticMethods.Zodiac((DateTime)birthDate));
                ViewBag.Zodiac = zodiac.ToString().ToLower();
                ViewBag.FirstName = firstName;
            }
            return View();
        }

        public IActionResult Opdracht6_6(int baseNumber = 0, int power = 0)
        {

            // Schrijf een programma voor machtverheffen met 2 getallen.

            ViewBag.Result = StaticMethods.Power(baseNumber, power);
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
            ViewData["weekend"] = StaticMethods.IsWeekend(today);
            ViewData["leapyear"] = StaticMethods.IsLeapYear(today);
            return View();
        }



    }
}
