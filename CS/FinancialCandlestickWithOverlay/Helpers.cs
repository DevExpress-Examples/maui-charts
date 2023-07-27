using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialChartExample
{
    public static class DateTimeUtils {
        public static DateTime Round(this DateTime dateTime, TimeFrame timeFrame) {
            switch (timeFrame) {
                case TimeFrame.M15:
                    return getTimeIntervalForMinuteTimeFrame(dateTime, 15);
                case TimeFrame.M30:
                    return getTimeIntervalForMinuteTimeFrame(dateTime, 30);
                case TimeFrame.H1:
                    return getTimeIntervalForHourTimeFrame(dateTime, 1);
                case TimeFrame.H2:
                    return getTimeIntervalForHourTimeFrame(dateTime, 3);
                case TimeFrame.H4:
                    return getTimeIntervalForHourTimeFrame(dateTime, 4);
                case TimeFrame.D:
                    return dateTime.Date;
                default:
                    throw new NotSupportedException();
            }
        }

        public static DateTime Add(this DateTime dateTime, TimeFrame timeFrame, int count = 1) {
            switch (timeFrame) {
                case TimeFrame.M15:
                    return dateTime.AddMinutes(15 * count);
                case TimeFrame.M30:
                    return dateTime.AddMinutes(30 * count);
                case TimeFrame.H1:
                    return dateTime.AddHours(1 * count);
                case TimeFrame.H2:
                    return dateTime.AddHours(2 * count);
                case TimeFrame.H4:
                    return dateTime.AddHours(4 * count);
                case TimeFrame.D:
                    return dateTime.AddDays(1 * count);
                default:
                    throw new NotSupportedException();
            }
        }

        //public static bool IsWeekend(this DateTime date) {
        //    return date.DayOfWeek == DayOfWeek.Sunday
        //        || date.DayOfWeek == DayOfWeek.Monday;
        //}

        //public static int InRange(this DateTime value, DateTime start, DateTime end) {
        //    if (value > end) return 1;
        //    if (value < start) return -1;
        //    return 0;
        //}

        static DateTime getTimeIntervalForMinuteTimeFrame(DateTime dateTime, int minutes) {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute / minutes * minutes, 0);
        }

        static DateTime getTimeIntervalForHourTimeFrame(DateTime dateTime, int hours) {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour / hours * hours, 0, 0);
        }
    }
}
