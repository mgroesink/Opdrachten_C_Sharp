using System;
using System.Globalization;

namespace RskExtensions
{
	public static class IntExtensions
	{
        public static bool IsAutomorph(this int value)
        {
            int pow2 = (int)Math.Pow(value, 2);

            if (pow2.ToString().EndsWith(value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDisarium(this int value)
        {
			int sum = 0;
			foreach(char item in value.ToString())
            {
				int number = int.Parse(item.ToString());
				sum += (int)Math.Pow(number, 2);

            }
			return value == sum;
        }
		public static string FizzBuzz(this int value)
		{
			if (value % 3 == 0 && value % 5 == 0)
			{
				return "FizzBuzz";
			}

			if (value % 3 == 0) // Deelbaar door 3
			{
				return "Fizz";
			}

			if (value % 5 == 0)
			{
				return "Buzz";
			}


			return value.ToString();
		}
	}
}
