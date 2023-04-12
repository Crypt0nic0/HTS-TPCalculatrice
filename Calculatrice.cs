using System;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public int OperanteGauche { get; set; }
        public int OperanteDroite { get; set; }
        public int Resultat { get; set; }


        public Calculatrice(int a, int b)
        {
            OperanteGauche = a;
            OperanteDroite = b;
        }



        public void Addition()
        {
            Resultat = OperanteGauche + OperanteDroite;
        }

        public void Soustraction()
        {
            Resultat = OperanteGauche - OperanteDroite;
        }

        public void Multiplication()
        {
            Resultat = OperanteGauche * OperanteDroite;
        }

        public void Division()
        {
            Resultat = 0;
            if (OperanteDroite != 0)
            {
                Resultat = OperanteGauche / OperanteDroite;
            }
        }

        public void Modulo()
        {
            Resultat = OperanteGauche % OperanteDroite;
        }
    }
}
