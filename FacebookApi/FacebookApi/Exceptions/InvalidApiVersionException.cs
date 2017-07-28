using System;

namespace FacebookApi.Exceptions
{
    /// <summary>
    /// Represents Invalid Api Version Exception
    /// </summary>
    [Serializable]
    public class InvalidApiVersionException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="InvalidApiVersionException"/>
        /// </summary>
        public InvalidApiVersionException() : base("Invalid Facebook API version specified.")
        {
        }
    }
}
