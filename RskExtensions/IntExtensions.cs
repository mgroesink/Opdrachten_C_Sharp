namespace RskExtensions
{
    public static class IntExtensions
    {
        /// <summary>Determines whether this instance is automorph.</summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is automorph; otherwise, <c>false</c>.</returns>
        public static bool IsAutomorph(this int value)
        {
            int pow2 = (int)Math.Pow(value, 2);
            return pow2.ToString().EndsWith(value.ToString());
        }

        public static bool IsDisarium(this int value)
        {
            int sum = 0;
            var digits = value.ToString();
            for(int i = 0; i < digits.Length; i++)
            {
                int number = int.Parse(digits[i].ToString());
                sum += (int)Math.Pow(number, i + 1);
            }
            return value == sum;
        }
    }
}