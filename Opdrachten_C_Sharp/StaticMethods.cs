using System;
using System.Text;

namespace Opdrachten_C_Sharp
{
    public static class StaticMethods
    {
        private const string CAPITALS = "ABCDEFGHIJKLMNOPQRSTUVW";
        private const string NONCAPITALS = "abcdefghijklmnopqrstuvwxyz";
        private const string DIGITS = "0123456789";
        private static Random r = new Random();

        /// <summary>
        /// Luizenmoeder.
        /// </summary>
        /// <returns></returns>
        public static string LuizenMoeder()
        {
            return "Hallo allemaal wat leuk dat jullie er zijn";
        }

        /// <summary>
        /// Powers the specified base number.
        /// </summary>
        /// <param name="baseNumber">The base number.</param>
        /// <param name="pow">The pow.</param>
        /// <returns></returns>
        public static int Power(int baseNumber, int pow)
        {
            var result = baseNumber;
            for (int i = 1; i < pow; i++)
            {
                result *= baseNumber;
            }
            return result;
        }

        /// <summary>
        /// Adds the numbers.
        /// </summary>
        /// <param name="v1">The v1.</param>
        /// <param name="v2">The v2.</param>
        /// <returns></returns>
        public static int AddNumbers(int v1, int v2)
        {
            return v1 + v2;
        }

        /// <summary>
        /// Gets the zodiac of a specified date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Determines whether [is leap year].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is leap year]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLeapYear()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Determines whether [is leap year] [the specified date].
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified date]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLeapYear(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year);
        }

        /// <summary>
        /// Determines whether the specified date is weekend.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns>
        ///   <c>true</c> if the specified date is weekend; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek ==
                DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static string Encrypt(string text, int key)
        {
            text = text.ToUpper();
            string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            StringBuilder encryptedText = new StringBuilder();
            foreach (var letter in text)
            {
                int position = alphabet.IndexOf(letter);
                int newPosition = (position + key) % 26;
                encryptedText.Append(alphabet[newPosition].ToString());
            }
            return encryptedText.ToString();
        }

        /// <summary>
        /// Decrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static string Encrypt(string text, string key)
        {
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int ascii1 = (int)text[i];
                int ascii2 = (int)key[i];
                int sum = (ascii1 + ascii2) % 256;
                string outputHex = sum.ToString("X");
                if (outputHex.Length == 1)
                {
                    outputHex = "0" + outputHex;
                }
                encryptedText.Append(outputHex);
            }


            return encryptedText.ToString();
        }

        /// <summary>
        /// Decrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static string Decrypt(string text, string key)
        {
            StringBuilder decryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                int ascii1 = Convert.ToInt32(text.Substring(i, 2), 16);
                int ascii2 = (int)key[i / 2];
                int sum = (ascii1 - ascii2 + 256) % 256;

                decryptedText.Append(((char)sum).ToString());
            }


            return decryptedText.ToString();
        }

        /// <summary>
        /// Gets a unique code from letters and digits.
        /// </summary>
        /// <param name="unwanted">The unwanted chars.</param>
        /// <returns></returns>
        public static string GetCode(int length, string unwanted, bool onlycaptitals = true)
        {
            StringBuilder sb = new StringBuilder();
            string chars = onlycaptitals ? CAPITALS + DIGITS :
                CAPITALS + NONCAPITALS + DIGITS;
            if (onlycaptitals)
            {
                unwanted = unwanted.ToUpper();
            }
            // Remove all unwanted characters
            foreach (char c in unwanted)
            {
                chars = chars.Replace(c.ToString(), "");
            }
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[r.Next(chars.Length)]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Creates a random password.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static string CreatePassword(int length)
        {
            StringBuilder sb = new StringBuilder();
            while (sb.Length < length)
            {
                var randomOption = r.Next(4);
                switch (randomOption)
                {
                    case 0:
                        sb.Append(GetRandomLetter('U'));
                        break;
                    case 1:
                        sb.Append(GetRandomLetter('L'));
                        break;
                    case 2:
                        sb.Append(r.Next(10));
                        break;
                    case 3:
                        sb.Append(GetSpecialCharacter());
                        break;
                }
            }

            // Replace a random character with a random special 
            // character to be sure that the password has
            // at least one special character
            sb[r.Next(sb.Length)] = GetSpecialCharacter();
            return sb.ToString();
        }

        /// <summary>
        /// Gets a random letter.
        /// </summary>
        /// <param name="upperlower">The upperlower.</param>
        /// <returns></returns>
        private static char GetRandomLetter(char upperlower)
        {
            if (upperlower == 'U')
                return CAPITALS[r.Next(CAPITALS.Length)];
            else
                return NONCAPITALS[r.Next(NONCAPITALS.Length)];
        }

        /// <summary>
        /// Gets a special character.
        /// </summary>
        /// <returns></returns>
        private static char GetSpecialCharacter()
        {
            string chars = "!@#$%&*";
            return chars[r.Next(chars.Length)];
        }
    }
}
