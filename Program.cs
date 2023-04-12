using TPCalculatrice;
using TPCalculatrice.Operations;

Console.WriteLine("======== CALCULATRICE ========");

Console.WriteLine("Veuillez saisir un premier chiffre : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez saisir un deuxièmre chiffre : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Saisir un opérateur entre + - * / % : ");
string op = Console.ReadLine();
Operation operation;

switch (op)
{
    case "+":
        operation = new Addition(a, b);
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
