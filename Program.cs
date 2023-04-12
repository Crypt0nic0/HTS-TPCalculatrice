using TPCalculatrice;
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

Console.WriteLine("Saisir un opérateur entre + - * / % : ");
string? op = Console.ReadLine();
Operation operation;

switch (op)
{
    case "+":
        operation = new Addition(a, b);
        Console.WriteLine("Voici le calcul demandé : " + operation.ToString());
        Addition a2 = new Addition(a, b);
        Console.WriteLine(operation.Equals(a2));
        break;
    case "-":
        operation = new Soustraction(a, b);
        break;
    case "*":
        operation = new Multiplication(a, b);
        break;
    case "/":
        operation = new Division(a, b);
        break;
    case "%":
        operation = new Modulo(a, b);
        break;
    default:
        Console.WriteLine("Opérateur incorrect");
        operation = new Addition(a, b);
        break;
}

Calculatrice calc = new Calculatrice(operation);
calc.Executer();

Console.WriteLine($"Résultat : {calc.Operation.Resultat}");
