using System;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public Operation Operation { get; set; }


        public Calculatrice(Operation operation)
        {
            Operation = operation;
        }

        public void Executer()
        {
            Operation.Executer();
        }

    }
}
