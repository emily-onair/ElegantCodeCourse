using System;

namespace Coding.Exercise
{
    public class HotelBooking 
    {
        public HotelBooking (string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            EndDate = startDate.AddDays(lengthOfStayInDays);
        }
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;
    }
}
