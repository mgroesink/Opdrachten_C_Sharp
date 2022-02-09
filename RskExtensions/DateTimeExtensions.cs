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
        /// <summary>Gets the weeknumber for the specified date.</summary>
        /// <param name="time">The time.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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

        /// <summary>Determines whether [is leap year].</summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified value]; otherwise, <c>false</c>.</returns>
        public static bool IsLeapYear(this DateTime value)
        {
			int year = value.Year;
			return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

        /// <summary>Determines whether this instance is day in the weekend.</summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is weekend; otherwise, <c>false</c>.</returns>
        public static bool IsWeekend(this DateTime value)
        {
			return value.DayOfWeek == DayOfWeek.Sunday ||
				value.DayOfWeek == DayOfWeek.Saturday;
        }
	}
}
