using System;

namespace TPCalculatrice.Operations
{
    // Classe Addition qui hérite de Opération
    public class Addition : Operation
    {
        // Pour instancier une Addition, on doit lui donner les 2 opérateurs...
        // qui sont necessaires dans l'Operation
        public Addition(int o1, int o2) : base(o1, o2) { }

        // La méthode Executer est abstract dans Operation, elle doit donc...
        // être redéfinie dans les héritiers.
        public override void Executer()
        {
            Resultat = OperanteGauche + OperanteDroite;
        }

        public override string ToString()
        {
            return $"{base.OperanteGauche} + {base.OperanteDroite}";
        }
    }
}
