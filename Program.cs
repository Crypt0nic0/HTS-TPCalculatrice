﻿using TPCalculatrice;
using TPCalculatrice.Operations;

int GetIntValue(string valeur)
{
    int? resultat = null;
    while (resultat is null)
    {
        Console.WriteLine($"Saisissez la {valeur} valeur entière");
        string? saisie = Console.ReadLine();
        if (saisie is not null)
        {
            try
            {
                resultat = int.Parse(saisie);
            }
            catch
            {
                resultat = null;
            }
        }
    }
    return resultat.Value;
}

Console.WriteLine("======== CALCULATRICE ========");

int a = GetIntValue("première");
int b = GetIntValue("deuxième");

Console.WriteLine();

try
{
    Console.WriteLine("Saisir un opérateur entre + - * / % : ");
    string? op = Console.ReadLine();
    if (op is null)
    {
        Console.WriteLine("Aucun opérateur saisi");
    }
    else
    {
        Operation operation = op switch
        {
            "+" => new Addition(a, b),
            "-" => new Soustraction(a, b),
            "*" => new Multiplication(a, b),
            "/" => new Division(a, b),
            "%" => new Modulo(a, b),
            _ => throw new OperateurNonReconnuException(op)
        };

        // switch (op)
        // {
        //     case "+":
        //         operation = new Addition(a, b);
        //         Console.WriteLine("Voici le calcul demandé : " + operation.ToString());
        //         Addition a2 = new Addition(a, b);
        //         Console.WriteLine(operation.Equals(a2));
        //         break;
        //     case "-":
        //         operation = new Soustraction(a, b);
        //         break;
        //     case "*":
        //         operation = new Multiplication(a, b);
        //         break;
        //     case "/":
        //         operation = new Division(a, b);
        //         break;
        //     case "%":
        //         operation = new Modulo(a, b);
        //         break;
        //     default:
        //         Console.WriteLine("Opérateur incorrect");
        //         operation = null;
        //         break;
        // }

        Calculatrice calc = new Calculatrice(operation);
        calc.Executer();
        Console.WriteLine($"Résultat : {calc.Operation.Resultat}");
    }
}
catch (OperateurNonReconnuException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine($"Erreur générale : {e.Message}");
}
