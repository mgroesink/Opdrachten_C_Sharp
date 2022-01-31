using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht5Controller : Controller
    {
        public IActionResult Opdracht5_1()
        {
            /*
             * Schrijf een programma dat de getallen 1 tot 25 op het scherm laat zien. 
             * Je moet hierbij gebruik maken van een FOR-lus. 
             */
            return View();
        }

        public IActionResult Opdracht5_8()
        {
            /*
             * Schrijf een programma dat de eerste 25 fibonacci getallen laat zien. 
             */
            var first = 0;
            var second = 1;
            var fibonacci = new StringBuilder("0<br/>1<br/>");
            for (var i = 0; i < 23; i++)
            {
                var sum = first + second;
                fibonacci.Append(sum + "<br/>");
                first = second;
                second = sum;
            }
            ViewBag.Fibonacci = fibonacci.ToString().Substring(0, fibonacci.Length - 2);
            return View();
        }

        public IActionResult Opdracht5_22()
        {
            /*
             * Schrijf nu een programma dat de som berekent van alle even getallen in de 
             * fibonacci reeks die kleiner zijn dan 4 miljoen.
             */
            var first = 0;
            var second = 1;
            var total = 0;
            var fibonacci = new StringBuilder("0<br/>1<br/>");
            while (true)
            {
                var sum = first + second;
                if (sum > 4000000) break;
                fibonacci.Append(sum + "<br/>");
                first = second;
                second = sum;
                if(sum % 2 == 0) total += sum;
            }
            ViewBag.Result = $"De som van alle even fibonacci getallen tot en met 4000000 is {total}";
            ViewBag.Fibonacci = fibonacci.ToString().Substring(0, fibonacci.Length - 2);
            return View();
        }
    }
}
