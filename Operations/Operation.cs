using System;

namespace TPCalculatrice.Operations
{
    public abstract class Operation
    {
        public int OperanteGauche { get; set; }
        public int OperanteDroite { get; set; }

        public int Resultat { get; set; }

        public Operation(int operanteGauche, int operanteDroite)
        {
            OperanteGauche = operanteGauche;
            OperanteDroite = operanteDroite;
        }

        public abstract void Executer();

    }
}
