using Microsoft.AspNetCore.Mvc;
using RskExtensions;
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

        public IActionResult Opdracht3_3(int width, int height, int length)
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

            var currencies = new Dictionary<string, double>();
            currencies["Amerikaanse dollar"] = euro * 1.13;
            currencies["Zweedse kroon"] = euro * 10.44;
            currencies["Zuid-Afrikaanse rand"] = euro * 17.16;
            currencies["Antilliaanse gulden"] = euro * 2;
            currencies["Braziliaanse real"] = euro * 5.95;
            ViewBag.Currency = currencies;
            ViewBag.Money = euro;
            return View();
        }

        public IActionResult Opdracht3_5(double length, double width)
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
            if (squarem2 > 0)
            {
                ViewBag.Width = width;
                ViewBag.Length = length;
                ViewBag.Cost1 = 12 * 1.5 * squarem2;
                ViewBag.Cost2 = 24 * 1.5 * squarem2 * .95; // 5% discount
                ViewBag.Cost3 = 36 * 1.5 * squarem2 * .9; // 10% discount
            }
            return View();
        }

        public IActionResult Opdracht3_6()
        {
            /*
             * Een school verstrekt aan de studenten twee keer per jaar een rapport. 
             * Een student volgt de volgende 6 vakken: NED, ENG, WIS, PRG, DBD en ALG.
             * Maak een programma dat voor een student een studentnummer vraagt,  
             * de voor- en achternaam en voor alle vakken het eerste en het tweede cijfer 
             * (beide cijfers met 1 decimaal). 
             * Daarna moet voor de opgegeven student een rapport worden weergegeven, 
             * waarbij per vak de behaalde cijfers en het (gewogen) gemiddelde worden 
             * weergegeven (ook met 1 decimaal). 
             * Voor de eerste 3 vakken tellen de toetsen even zwaar, 
             * voor de overige vakken telt het tweede cijfer 2 keer mee en het 
             * eerste cijfer 1 keer.
             */
            return View();
        }

        [HttpPost]
        public IActionResult Opdracht3_6(string studentnummer, string voornaam,
            string achternaam, float[] cijfers1,
            float[] cijfers2)
        {
            var eindcijfers = new float[6];
            for (int i = 0; i < 3; i++)
            {
                eindcijfers[i] = (cijfers2[i] + cijfers1[i]) / 2;

            }
            for (int i = 3; i < 6; i++)
            {
                eindcijfers[i] = ((cijfers2[i] * 2) + cijfers1[i]) / 3;

            }
            ViewBag.Naam = voornaam + " " + achternaam;
            ViewBag.Studentnummer = studentnummer;
            ViewBag.Cijfers1 = cijfers1;
            ViewBag.Cijfers2 = cijfers2;
            ViewBag.Eindcijfers = eindcijfers;
            return View("Rapport3_6");
        }

        public IActionResult Opdracht3_7(string text = "")
        {
            ViewBag.Original = text;
            ViewBag.Text = text.Replace("a", "*").
                Replace("A", "*").
                Replace("e", "*").
                Replace("E", "*").
                Replace("i", "*").
                Replace("I", "*").
                Replace("o", "*").
                Replace("O", "*").
                Replace("u", "*").
                Replace("U", "*");
            return View();
        }

        public IActionResult Opdracht3_8(string voornaam, string tussenvoegsels,
            string achternaam)
        {
            string username = voornaam.Substring(0, 1) + achternaam +
                (voornaam + tussenvoegsels + achternaam).Replace(" ", "").Length.ToString();
            if (!string.IsNullOrEmpty(username))
            {
                ViewBag.Username = username.ToLower();
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
    }
}
