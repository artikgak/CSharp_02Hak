using System;

namespace KMACSharp02_03Hak.Exceptions
{
    class InvalidSurnameException:Exception
    {
        public InvalidSurnameException() { }
        public InvalidSurnameException(string surname) : base("Error. invalid Surname entered: " + surname) { }
        public InvalidSurnameException(string surname, Exception inner) : base("Error. invalid Surname entered: " + surname, inner) { }
    }
}
