using System;

namespace TPCalculatrice
{
    public class Calculatrice
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            int resu = 0;
            if (b != 0)
            {
                resu = a / b;
            }
            return resu;
        }

        public int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
