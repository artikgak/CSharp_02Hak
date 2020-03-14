﻿using System;

namespace KMACSharp02Hak.Exceptions
{
    internal class BirthDateInFutureException : Exception
    {
        public BirthDateInFutureException(string message) : base(message) { }
        public BirthDateInFutureException(string message, Exception inner) : base(message, inner) { }
    }
}