using System;

namespace Coding.Exercise
{
    public class DailyAccountState
    {
        public int InitialState { get; }
        
        public int SumOfOperations { get;}
        
        public DailyAccountState(
            int initialState, 
            int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }
        
        public int EndOfDayState => InitialState + SumOfOperations;
        
        public string Report {
            get {
                var today = DateTime.Now;
                return $"Day: {today.Day}, month: {today.Month}, year: {today.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
            }
        }
    }
}
