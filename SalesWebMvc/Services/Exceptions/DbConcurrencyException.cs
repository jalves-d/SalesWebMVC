using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Services
{
    public class DbConcurrencyException : Exception
    {
        public DbConcurrencyException(string message) : base(message)
        {
        }
    }
}