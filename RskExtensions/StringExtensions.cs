using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RskExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether this instance is numeric.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if the specified text is numeric; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumeric(this string text)
        {
            foreach (char c in text)
            {
                if(!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Determines whether this instance is alpha numeric.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if [is alpha numeric] [the specified text]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAlphaNumeric(this string text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c) || char.IsLetter(c)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
