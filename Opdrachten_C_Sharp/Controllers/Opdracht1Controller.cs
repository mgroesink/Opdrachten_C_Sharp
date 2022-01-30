using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht1Controller : Controller
    {
        public IActionResult Opdracht1_1()
        {
            /*
             Schrijf een programma dat de volgende informatie van jou op het scherm laat zien:
                    •  Jouw volledige naam
                    •  Jouw adres
                    •  Jouw postcode gevolgd door jouw woonplaats (op één regel)
                    •  Jouw leeftijd

             */
            string info = "<h4>Marcel Roesink</h4>";
            info += "<br/>Laan van Scherpzicht";
            info += "<br/>7890 DW  Scherpenzeel";
            info += "<br/>Leeftijd: 63";
            ViewBag.Info = info;
            return View();
        }
        public IActionResult Opdracht1_2()
        {
            /*
             * Schrijf een programma dat jouw naam weergeeft in een box met sterretjes, zoals hieronder weergegeven:
                ********************
                ***     Marcel   ***
                ********************

             */
            string info = "<p style='font-family: Courier New'>";
                info += "*".PadRight(24,'*');
            info += "<br/>";
            info += "******** MARCEL ********"; 
            info += "<br/>" + "*".PadRight(24, '*');
            info += "</p>";

            ViewBag.Info = info;
            return View("Opdracht1_1");
        }
    }
}
