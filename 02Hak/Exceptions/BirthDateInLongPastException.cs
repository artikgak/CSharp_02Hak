﻿using System;

namespace KMACSharp02Hak.Exceptions
{
    internal class BirthDateInLongPastException : Exception
    {
        public BirthDateInLongPastException(string message) : base(message) { }
        public BirthDateInLongPastException(string message, Exception inner) : base(message, inner) { }
    }
}