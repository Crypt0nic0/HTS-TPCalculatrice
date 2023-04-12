using System;

namespace TPCalculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int o1, int o2)
            : base(o1, o2)
        {

        }

        public void Executer()
        {
            Resultat = OperanteGauche * OperanteDroite;
        }
    }
}
