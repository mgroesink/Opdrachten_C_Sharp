﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;

namespace Opdrachten_C_Sharp.Controllers
{
    public class Opdracht7Controller : Controller
    {
        public IActionResult Opdracht7_1(int[] numbers)
        {
            /*
            Vraag de gebruiker 5 getallen in te voeren en sla de 
            getallen op in een array. 
            Geef daarna de ingevoerde getallen als volgt weer:
                Het eerste getal is: …
                Het tweede getal is: …

             */
            if (numbers != null)
            {
                return View(numbers);
            }
            return View();
        }
        public IActionResult Opdracht7_2()
        {
            Random r = new Random();

            string[] names = new string[]
            {
                "Youri",
                "Dennis",
                "Thom",
                "Sten",
                "Bram",
                "Mike",
                "Calvin",
                "Thijs",
                "Chris",
                "Kayra",
                "Johan",
                "Stein",
                "Rayan",
                "Michiel",
                "Damiën",
                "Damian",
                "Mitchel",
                "Dario",
                "Vincent",
                "Guus",
                "Malik",
                "Walid",
                "Clint",
                "Sydney"
            };

            int randomNumber = r.Next(names.Length);
            ViewBag.Name = names[randomNumber];
            return View();

        }
        public IActionResult Opdracht7_3()
        {
            /*
             * Maak een programma dat 25 random gehele getallen tussen 1 en 10000 
             * in een array plaatst. 
             * Vervolgens moeten eerst alle even getallen uit de array 
             * worden weergegeven en daarna alle oneven getallen.
             */
            Random r = new Random();
            int[] array1d = new int[25];
            for (int i = 0; i < array1d.Length; i++)
            {
                array1d[i] = r.Next(1, 10000);
            }
            return View(array1d);
        }
        public IActionResult Opdracht7_4(string submit, int length = 10)
        {
            /*
            De gebruiker moet kunnen aangeven hoelang het password moet zijn. 
            Waarna er een random password moet worden gegenereerd met cijfers, 
            letters en een vreemd karakter(!,@,#,$,%,^,&,*).
            Het gegenereerde password moet op het scherm getoond worden.
            Het wachtwoord moet minimaal 10 karakters hebben en maximaal 60.
            */
            if (submit == "Genereer wachtwoord")
            {
                if ((length < 10 || length > 60))
                {
                    ViewBag.Error = "Wachtwoord moet minimaal 10 en maximaal 60 tekens lang zijn";
                    return View();
                }
                ViewBag.Password = StaticMethods.CreatePassword(length);
            }
            ViewBag.Length = length;
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
        public IActionResult Opdracht7_14(string submit, int balls = 6, int max = 45, bool jackpot = true)
        {
            if (!string.IsNullOrEmpty(submit))
            {

                // Array to hold the choosen numbers
                int[] lottery = new int[balls];
                Random random = new Random();
                for (int i = 0; i < balls; i++)
                {
                    // Get a random number
                    int ball = random.Next(1, max + 1);
                    if (!lottery.Contains(ball))
                    {
                        // Add ball to the array
                        lottery[i] = ball;
                    }
                    else
                    {
                        // Ball is already choosen
                        i--;
                    }
                }

                // Sort the array from low to high
                Array.Sort(lottery);
                ViewBag.Balls = lottery;
                int color = random.Next(6);
                ViewBag.ForeColor = "black";
                switch (color)
                {
                    case 0:
                        ViewBag.Color = "yellow";
                        break;
                    case 1:
                        ViewBag.Color = "red";
                        break;
                    case 2:
                        ViewBag.Color = "blue";
                        break;
                    case 3:
                        ViewBag.Color = "white";
                        break;
                    case 4:
                        ViewBag.Color = "green";
                        break;
                    case 5:
                        ViewBag.Color = "gray";
                        break;

                }
                if (!jackpot)
                {
                    ViewBag.Color = "black";
                    ViewBag.ForeColor = "white";
                }
            }

            return View();
        }
        public IActionResult Opdracht7_15(string submit, string unwanted)
        {
            /*
            Een leverancier van zuivelproducten hanteert een spaarsysteem, 
            waarbij klanten die een product hebben gekocht een code kunnen 
            invoeren op een website. Deze code bestaat uit (hoofd)letters en 
            cijfers en de lengte van de code is 11 tekens. Echter, sommige 
            tekens lijken teveel op elkaar en daarom worden de 
            cijfers 0 en 1 niet gebruikt en ook de letters i en o niet.
            
            Aan jou de taak het programma te schrijven. 
            Het resultaat moet een array met 11 tekens zijn en de 
            methode kent één parameter: een array met de tekens die 
            niet zijn toegestaan. Op die manier kan de gebruiker van 
            het programma zelf bepalen welke tekens niet zijn toegestaan.
            */

            if (submit == "Genereer code")
            {
                unwanted = unwanted ?? "";
                ViewBag.Code = StaticMethods.GetCode(11, unwanted);
            }


            return View();
        }

        /// <summary>
        /// Generates a random key.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
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
