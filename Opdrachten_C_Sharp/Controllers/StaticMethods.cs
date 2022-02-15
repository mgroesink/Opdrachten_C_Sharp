using System;
using System.Text;

namespace Opdrachten_C_Sharp.Controllers
{
    public static class StaticMethods
    {
        public static string Encrypt(string password, int key)
        {
            password = password.ToUpper();
            StringBuilder sb = new StringBuilder();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in password)
            {
                int pos = alphabet.IndexOf(c);
                int newPos = (pos + key) % 26;
                char newChar = alphabet[newPos];
                sb.Append(newChar);
            }

            return sb.ToString();
        }

        public static string Decrypt(string encrypted, int key)
        {
            encrypted = encrypted.ToUpper();
            StringBuilder sb = new StringBuilder();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in encrypted)
            {
                int pos = alphabet.IndexOf(c);
                int newPos = (pos - key + 26) % 26;
                char newChar = alphabet[newPos];
                sb.Append(newChar);
            }

            return sb.ToString();
        }

        public static string FilterCharacters(string filter)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower() + "0123456789";

            foreach (var letter in filter)
            {
                alphabet = alphabet.Replace(letter.ToString(), "");
            }
            return alphabet;
        }
    }
}