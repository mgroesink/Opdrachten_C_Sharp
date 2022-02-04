using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RskExtensions
{
    public static class DateTimeExtensions
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

		public static bool IsLeapYear(this DateTime value)
        {
			int year = value.Year;
			return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

		public static bool IsWeekend(this DateTime value)
        {
			return value.DayOfWeek == DayOfWeek.Sunday ||
				value.DayOfWeek == DayOfWeek.Saturday;
        }
	}
}
