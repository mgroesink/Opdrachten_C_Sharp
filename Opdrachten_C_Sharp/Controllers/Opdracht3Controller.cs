using Microsoft.AspNetCore.Mvc;
using System;

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
    }
}
