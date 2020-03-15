using System;

namespace KMACSharp02_03Hak.Exceptions
{
    internal class BirthDateInLongPastException : Exception
    {
        public BirthDateInLongPastException(DateTime date) : base("Error. Date in long past picked: " + date.ToShortDateString()) { }
        public BirthDateInLongPastException(DateTime date, Exception inner) : base("Error. Date in long past picked: " + date.ToShortDateString(), inner) { }
    }
}