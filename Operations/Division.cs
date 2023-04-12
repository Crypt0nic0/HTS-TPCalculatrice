using System;

namespace TPCalculatrice.Operations
{
    public class Division : Operation
    {
        public Division(int o1, int o2) : base(o1, o2) { }

        public override void Executer()
        {
            if (OperanteDroite != 0)
            {
                Resultat = OperanteGauche / OperanteDroite;
            }
        }
    }
}
