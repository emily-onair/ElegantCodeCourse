using System;

namespace Coding.Exercise
{
    public class Pair<T>
    {
        public T First { get; private set; }
        public T Second { get; private set; }
        public Pair(T first, T second)
        {
            this.First = first;
            this.Second = second;
        }

        public void ResetFirst()
        {
            First = default;
        }

        public void ResetSecond()
        {
            Second = default;
        }
    }
}
