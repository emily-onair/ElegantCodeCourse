using System;

namespace Coding.Exercise
{
    public static class ListExtensions
    {
        public static List<int> TakeEverySecond(this List<int> input) {
            List<int> newList = new List<int>();
            int i = 0;
            while (i < input.Count) {
                if (i % 2 == 0) {
                    newList.Add(input[i]);
                }
                i++;
            }
            return newList;
        }
    }
}
