using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models.Block1;

namespace Opdrachten_C_Sharp.Controllers
{
    public partial class Block1Controller
    {
        Me marcel = new Me();
        public Block1Controller()
        {

        }
        public IActionResult Exercise1Marcel()
        {
            /*
             Schrijf een programma dat de volgende informatie van jou op het scherm laat zien:
                    •  Jouw volledige naam
                    •  Jouw adres
                    •  Jouw postcode gevolgd door jouw woonplaats (op één regel)
                    •  Jouw leeftijd

             */

            marcel.FirstName = "Marcel";
            marcel.LastName = "Bosman";
            marcel.Address = "Laan van Scherpzicht 23";
            marcel.PostalCode = "7890DW";
            marcel.City = "Scherpenzeel";
            marcel.Age = 66;

            return View(marcel);
        }
        public IActionResult Exercise2Marcel()
        {
            /*
             * Schrijf een programma dat jouw naam weergeeft in een box met sterretjes, zoals hieronder weergegeven:
                ********************
                ***     Marcel   ***
                ********************

             */

            return View(marcel);
        }
    }
}
