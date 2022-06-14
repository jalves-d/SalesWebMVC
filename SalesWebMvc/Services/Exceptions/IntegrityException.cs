using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Services
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}