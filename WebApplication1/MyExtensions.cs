using System;
using System.Globalization;

namespace Opdrachten_C_Sharp
{
	public static class MyEntensions
	{
		public static int Weeknumber(this DateTime time)
		{
			// Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
			// be the same week# as whatever Thursday, Friday or Saturday are,
			// and we always get those right
			DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
			if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
			{
				time = time.AddDays(3);
			}

			// Return the week of our adjusted day
			return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

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
