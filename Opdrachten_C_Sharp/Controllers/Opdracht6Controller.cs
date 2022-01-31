using Microsoft.AspNetCore.Mvc;
using System;

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
    }
}
