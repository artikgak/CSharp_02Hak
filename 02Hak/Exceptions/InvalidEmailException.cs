﻿using System;

namespace KMACSharp02_03Hak.Exceptions
{
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException() { }
        public InvalidEmailException(string email) : base("Error. Invalid Email entered: " + email) { }
        public InvalidEmailException(string email, Exception inner) : base("Error. Invalid Email entered: " + email, inner) { }
    }
}