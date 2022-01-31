using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht2Controller : Controller
    {
        public IActionResult Opdracht2_1(double weight, int length)
        {
            /*
             * Maak een programma dat van een gebruiker de BMI uitrekent. 
             * De gebruiker voert zijn gewicht in (in kg. met 1 decimaal) 
             * en zijn lengte (in cm.) en daarna wordt de BMI getoond.
             */
            if (weight > 0 && length > 0)
            {
                var lengthM = length / 100.0;
                var bmi = Math.Round(weight / Math.Pow(lengthM, 2), 2);
                double max = 25 * (Math.Pow(lengthM, 2));
                double min = 18.5 * (Math.Pow(lengthM, 2));
                ViewBag.Advice =
                    $"Bij uw lengte van {length} cm. hoort een gewicht tussen {min:n2} en {max:n2} kg.";


                ViewBag.BMI = bmi;
            }
            return View();
        }

        public IActionResult Opdracht2_2(int? number1, int? number2)
        {
            /*
             Maak een programma waarin de gebruiker 2 getallen geeft. Vervolgens moet het programma de uitkomst van de volgende berekeningen laten zien:
               •  Eerste getal plus tweede getal
               •  Eerste getal min tweede getal
               •  Tweede getal min eerste getal
               •  Eerste getal maal tweede getal
               •  Eerste getal gedeeld door tweede getal
               •  Tweede getal gedeeld door eerste getal
               •  Restant (modulo) van eerste getal gedeeld door tweede getal
               •  Restant (modulo) van tweede getal gedeeld door eerste getal
             */
            ViewBag.Number1 = number1;
            ViewBag.Number2 = number2;
            return View();
        }

        public IActionResult Opdracht2_3(DateTime birthDate, string name = "")
        {
            var age = DateTime.Now.Year - birthDate.Year;
            if(DateTime.Now.Month < birthDate.Month)
            {
                age--;
            }
            else if(DateTime.Now.Month == birthDate.Month &&
                DateTime.Now.Day < birthDate.Day)
            {
                age--;
            }
            if (!string.IsNullOrEmpty(name))
            {
                ViewBag.Name = name;
                ViewBag.Age = age;
            }
            return View();
        }

        public IActionResult Opdracht2_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Opdracht2_4(string name , int basicprice , string[] options)
        {
            double total = basicprice;
            if (options.Any(o=>o.Contains("metalic")))
            {
                total += basicprice * 0.05;
                ViewBag.Metalic = true;
            }
            else
            {
                ViewBag.Metalic = false;
            }
            if (options.Any(o => o.Contains("leather")))
            {
                total += basicprice * 0.05;
                ViewBag.Leather = true;
            }
            else
            {
                ViewBag.Leather = false;
            }
            if (options.Any(o => o.Contains("auto")))
            {
                total += 1000;
                ViewBag.Auto = true;
            }
            else
            {
                ViewBag.Auto = false;
            }
            ViewBag.TotalEx = total;
            ViewBag.BTW = total * 0.21;
            total *= 1.21;
            ViewBag.TotalIncl = total;

            ViewBag.Name = name;
            ViewBag.BasicPrice = basicprice;
            return View();
        }

    }
}
