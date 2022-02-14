using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht7Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Opdracht7_12()
        {
            /*
            Schrijf een programma waarbij de gebruiker een wachtwoord opgeeft en een key. 
            Het wachtwoord mag alleen uit hoofdletters bestaan en de key is een geheel 
            getal tussen 1 en 26. 
            De key bepaalt hoeveel tekens we verspringen en als we voorbij de laatste 
            letter komen gaan we verder met de A.
            Vervolgens wordt de volgende informatie weergegeven (uitgaande van een 
            wachtwoord HALLO en een key van 3:
                Het wachtwoord is: HALLO
                Het versleutelde wachtwoord is: KDOOR
                Het originele wachtwoord was: HALLO
                Het wachtwoord is: MAZZEL
                Het versleutelde wachtwoord is: PDCCHO
                Het originele wachtwoord was: MAZZEL
 
            Schrijf aparte methodes voor het versleutelen en ontsleutelen. 
            Beide methodes hebben een string als resultaat en twee parameters: 
            een string en een geheel getal.
             */

            return View();
        }

        [HttpPost]
        public IActionResult Opdracht7_12(string password = "", int key = 0)
        {
            ViewBag.Password = password;
            string encrypted = StaticMethods.Encrypt(password, key);
            ViewBag.Encrypted = encrypted;
            ViewBag.Decrypted = StaticMethods.Decrypt(encrypted, key);
            return View();
        }

        public IActionResult Opdracht7_13()
        {
            /*
            Schrijf een programma waarbij de gebruiker een wachtwoord opgeeft en een key. 
            •	als key gebruiken we een random string die even lang is als de te versleutelen tekst.
            •	de ASCII waarde van het teken op een bepaalde positie tellen we op bij de ASCII waarde van het teken op dezelfde positie van de key.
            •	De gevonden waarde zetten we om naar de hexadecimale waarde van het bijbehorende teken. Als de hexadecimale waarde uit 1 teken bestaat plaatsen we er een 0 voor, zodat we altijd 2 tekens hebben.
            •	Als de waarde boven 127 komt beginnen we weer bij 0. Dus 156 wordt 156 – 128 = 28

             */

            return View();
        }

        [HttpPost]
        public IActionResult Opdracht7_13(string text = "")
        {
            if (text.TrimEnd() != "")
            {
                string randomKey = RandomKey(text.Length);
                string encrypted = StaticMethods.Encrypt(text, randomKey);

                ViewBag.Text = text;
                ViewBag.Key = randomKey;
                ViewBag.Encrypted = encrypted;
                ViewBag.Decrypted = StaticMethods.Decrypt(encrypted, randomKey);

            }
            return View();
        }

        private string RandomKey(int length)
        {
            Random rnd = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyz" + "abcdefghijklmnopqrstuvwxyz".ToUpper() + "0123456789";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[rnd.Next(chars.Length)]);
            }
            return sb.ToString();
        }
    }
}
