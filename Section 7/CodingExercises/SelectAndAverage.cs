using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
        {
            return timeSpans.Average(timespan => timespan.TotalMilliseconds);
        }
    }
}
