using System;

namespace TPCalculatrice.Operations
{
    public abstract class Operation
    {
        // Une Operation a besoin de 2 operante
        // Elle fournira un Resultat
        protected int OperanteGauche { get; }
        protected int OperanteDroite { get; }

        public int Resultat { get; protected set; }


        // Pour instancier une Operation...
        // il faut donc lui donner les 2 operantes
        public Operation(int operanteGauche, int operanteDroite)
        {
            OperanteGauche = operanteGauche;
            OperanteDroite = operanteDroite;
        }

        // Une méthode Executer pour executer l'operation
        // Methode Abstract, elle doit donc être forcément re-définie dans les héritiers
        public abstract void Executer();

    }
}
