using System;

namespace BloggerWay.Shared.Utilities.Extensions
{
    public static class DateTimeExtensions
    {
        public static string FullDateAndTimeStringWithUnderscore(this DateTime datetime)
        {
            return $"{datetime.Millisecond} {datetime.Second} {datetime.Minute} {datetime.Hour} {datetime.Day} {datetime.Month} {datetime.Year}";

        }
    }
}
