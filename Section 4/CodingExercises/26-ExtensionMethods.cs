using System;

namespace Coding.Exercise
{
    public static class ListExtensions
    {
        public static List<int> TakeEverySecond(this List<int> input) {
            List<int> newList = new List<int>();
            for (int i = 0; i < input.Count; i += 2) {
                newList.Add(input[i]);
            }
            return newList;
        }
    }
}
