﻿using System;

namespace KMACSharp02_03Hak.Exceptions
{
    internal class BirthDateInFutureException : Exception
    {
        public BirthDateInFutureException() { }
        public BirthDateInFutureException(DateTime date) : base("Error. Date in future picked: " + date.ToShortDateString()) { }
        public BirthDateInFutureException(DateTime date, Exception inner) : base("Error. Date in future picked: " + date.ToShortDateString(), inner) { }
    }
}