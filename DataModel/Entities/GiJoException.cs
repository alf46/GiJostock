using System;

namespace DataModel
{
    public class GiJoException : Exception
    {
        public GiJoException(string message) : base(message)
        {
        }
    }
}