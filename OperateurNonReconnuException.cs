using System;
using System.Runtime.Serialization;

namespace TPCalculatrice
{
    public class OperateurNonReconnuException : Exception
    {
        public OperateurNonReconnuException()
        {
        }

        public OperateurNonReconnuException(string? message) : base(message)
        {
        }

        public OperateurNonReconnuException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OperateurNonReconnuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
