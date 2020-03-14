using System;

namespace KMACSharp02_03Hak.Exceptions
{
    internal class InvalidNameException: Exception
    {
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string message, Exception inner) : base(message, inner) { }
    }
}
