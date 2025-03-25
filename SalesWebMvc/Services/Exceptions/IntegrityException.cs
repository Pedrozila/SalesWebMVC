using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException()
        {
        }

        public IntegrityException(string message) : base(message)
        {
        }
    }
}
