using System;

namespace Coding.Exercise
{
    public class SortedList<T> where T: IComparable<T>
    {
        public IEnumerable<T> Items { get; }

        public SortedList(IEnumerable<T> items)
        {
            var asList = items.ToList();
            asList.Sort();
            Items = asList;
        }
    }
    
    public class FullName : IComparable<FullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    
        public override string ToString() => $"{FirstName} {LastName}";
    
        public int CompareTo(FullName other)
        {
            var lastNameCompare = string.Compare(LastName, other.LastName);
            if (lastNameCompare != 0) return lastNameCompare;
            return string.Compare(FirstName, other.FirstName);
        }
    }
}