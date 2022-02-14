using System;
using System.Text;

namespace Opdrachten_C_Sharp
{
    public static class StaticMethods
    {
        public static string LuizenMoeder()
        {
            return "Hallo allemaal wat leuk dat jullie er zijn";
        }

        public static int Power(int baseNumber , int pow)
        {
            var result = baseNumber;
            for(int i = 1; i < pow; i++)
            {
                result *= baseNumber;
            }
            return result;
        }

        public static int AddNumbers(int v1, int v2)
        {
            return v1 + v2;
        }

        public static string Zodiac(DateTime date)
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

        public static bool IsLeapYear()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }
        public static bool IsLeapYear(int year)
        {
            if (year < 50)
            {
                year = int.Parse(DateTime.Now.Year.ToString().Substring(0, 2)) * 100 + year;
            }
            else if (year < 100)
            {
                year = int.Parse(DateTime.Now.Year.ToString().Substring(0, 2)) * 100 - 1 + year;
            }

            return DateTime.IsLeapYear(year);
        }

        public static bool IsLeapYear(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year);
        }

        public static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek ==
                DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static string Encrypt(string text , int key)
        {
            text = text.ToUpper();
            string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            StringBuilder encryptedText = new StringBuilder();
            foreach(var letter in text)
            {
                int position = alphabet.IndexOf(letter);
                int newPosition = (position + key) % 26;
                encryptedText.Append(alphabet[newPosition].ToString());
            }
            return encryptedText.ToString();
        }

        public static string Decrypt(string text, int key)
        {
            text = text.ToUpper();
            string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            StringBuilder decryptedText = new StringBuilder();
            foreach (var letter in text)
            {
                int position = alphabet.IndexOf(letter);
                int newPosition = (position - key + 26) % 26;
                decryptedText.Append(alphabet[newPosition].ToString());
            }
            return decryptedText.ToString();
        }
    }
}
