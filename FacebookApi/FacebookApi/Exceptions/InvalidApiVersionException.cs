using System;

namespace FacebookApi.Exceptions
{
    [Serializable]
    public class InvalidApiVersionException : Exception
    {
        public InvalidApiVersionException() : base("Invalid Facebook API version specified.")
        {
        }
    }
}
