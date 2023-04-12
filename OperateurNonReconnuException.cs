using System;
using System.Runtime.Serialization;

namespace TPCalculatrice
{
    public class OperateurNonReconnuException : Exception
    {
        public string Operateur { get; set; } = "";
        public OperateurNonReconnuException()
        {
        }

        public OperateurNonReconnuException(string operateur)
        : base($"L'opérateur {operateur} n'est pas reconnu")
        {
            if (string.IsNullOrWhiteSpace(operateur))
            {
                throw new ArgumentException($"'{nameof(operateur)}' cannot be null or whitespace.", nameof(operateur));
            }

            Operateur = operateur;
        }

        public OperateurNonReconnuException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OperateurNonReconnuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
