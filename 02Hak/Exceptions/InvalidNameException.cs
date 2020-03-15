﻿using System;

namespace KMACSharp02_03Hak.Exceptions
{
    internal class InvalidNameException: Exception
    {
        public InvalidNameException() { }
        public InvalidNameException(string name) : base("Error. invalid Name entered: " + name) { }
        public InvalidNameException(string name, Exception inner) : base("Error. invalid Name entered: " + name, inner) { }
    }
}
