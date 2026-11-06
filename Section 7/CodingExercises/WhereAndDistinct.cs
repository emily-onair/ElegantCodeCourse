using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates) 
        {
            return dates.Distinct().Where(date => 
                date.DayOfWeek == DayOfWeek.Friday && 
                date.Year == year);
        }
    }
}
