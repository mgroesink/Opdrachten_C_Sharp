using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Opdrachten_C_Sharp.Models.Block3
{
    public class PasswordOptions
    {
        #region Properties
        [Range(6, 50, ErrorMessage = "De minimum lengte moet tussen 6 en 50 liggen.")]
        public int MinLength { get; set; } = 6;

        [Range(1, 5, ErrorMessage = "Het aantal hoofdletters moet tussen 1 en 5 liggen.")]
        public int UppercaseLetters { get; set; } = 1;

        [Range(1, 5, ErrorMessage = "Het aantal kleine letters moet tussen 1 en 5 liggen.")]
        public int LowercaseLetters { get; set; } = 1;

        [Range(1, 5, ErrorMessage = "Het aantal cijfers moet tussen 1 en 5 liggen.")]
        public int Digits { get; set; } = 1;

        [Range(0, 5, ErrorMessage = "Het aantal speciale tekens moet tussen 0 en 5 liggen.")]
        public int SpecialCharacters { get; set; } = 0;
        public string GeneratedPassword { get; set; }
        public string ErrorMessage { get; set; }


        #endregion

        /// <summary>
        /// Generates the password.
        /// </summary>
        /// <param name="minLength">The minimum length.</param>
        /// <param name="uppercase">The number of uppercase characters.</param>
        /// <param name="lowercase">The number of lowercase characters.</param>
        /// <param name="digits">The number of digits.</param>
        /// <param name="specialChars">The number of special chars.</param>
        /// <returns></returns>
        public string GeneratePassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digitChars = "0123456789";
            const string specialCharSet = "+-=%@$&?!";

            var random = new Random();
            var password = new StringBuilder();

            // Voeg hoofdletters toe
            password.Append(GenerateRandomCharacters(upperChars, UppercaseLetters, random));

            // Voeg kleine letters toe
            password.Append(GenerateRandomCharacters(lowerChars, LowercaseLetters, random));

            // Voeg cijfers toe
            password.Append(GenerateRandomCharacters(digitChars, Digits, random));

            // Voeg speciale tekens toe
            password.Append(GenerateRandomCharacters(specialCharSet, SpecialCharacters, random));

            // Als het wachtwoord nog niet de minimale lengte heeft, vul aan
            int remainingLength = MinLength - password.Length;
            if (remainingLength > 0)
            {
                string allChars = upperChars + lowerChars + digitChars + specialCharSet;
                password.Append(GenerateRandomCharacters(allChars, remainingLength, random));
            }

            // Schud de karakters zodat ze in willekeurige volgorde staan
            return new string(password.ToString().ToCharArray().OrderBy(x => random.Next()).ToArray());
        }

        /// <summary>
        /// Generates the random characters.
        /// </summary>
        /// <param name="characterSet">The character set.</param>
        /// <param name="count">The count.</param>
        /// <param name="random">The random.</param>
        /// <returns></returns>
        private string GenerateRandomCharacters(string characterSet, int count, Random random)
        {
            return new string(Enumerable.Repeat(characterSet, count).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

