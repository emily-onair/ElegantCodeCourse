using System;

namespace Coding.Exercise
{
    public static class NumberToDayOfWeekTranslator {
        public static string Translate(int num) {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (num > 0 && num < 8) return days[num - 1];
            return "Invalid day of the week";
        }
    }
}
