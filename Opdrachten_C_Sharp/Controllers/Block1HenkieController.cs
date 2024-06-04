using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models.Block1;

namespace Opdrachten_C_Sharp.Controllers
{
    public partial class Block1Controller 
    {
        Me henkie = new Me();

        public IActionResult Exercise1Henkie()
        {
            /*
             Schrijf een programma dat de volgende informatie van jou op het scherm laat zien:

                    •  Jouw volledige naam
                    •  Jouw adres
                    •  Jouw postcode gevolgd door jouw woonplaats (op één regel)
                    •  Jouw leeftijd

             */

            henkie.FirstName = "Henkie";
            henkie.MiddleName = "van";
            henkie.LastName = "Leeuwen";
            henkie.Address = "Laan van Scherpzicht 25";
            henkie.PostalCode = "7890DW";
            henkie.City = "Scherpenzeel";
            henkie.Age = 30;

            return View(henkie);
        }
        public IActionResult Exercise2Henkie()
        {
            /*
             * Schrijf een programma dat jouw naam weergeeft in een box met sterretjes, zoals hieronder weergegeven:

                ********************
                ***     Marcel   ***
                ********************

             */

            henkie.FirstName = "Henkie";
            henkie.MiddleName = "van";
            henkie.LastName = "Leeuwen";
            henkie.Address = "Laan van Scherpzicht 25";
            henkie.PostalCode = "7890DW";
            henkie.City = "Scherpenzeel";
            henkie.Age = 30;

            return View(henkie);
        }
    }
}
