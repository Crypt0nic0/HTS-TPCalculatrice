using TPCalculatrice;

Console.WriteLine("======== CALCULATRICE ========");

Console.WriteLine("Veuillez saisir un premier chiffre : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez saisir un deuxièmre chiffre : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

Calculatrice maCalc = new Calculatrice(a, b);

Console.WriteLine("Saisir un opérateur entre + - * / % : ");
string op = Console.ReadLine();

switch (op)
{
    case "+":
        maCalc.Addition();
        break;
    case "-":
        maCalc.Soustraction();
        break;
    case "*":
        maCalc.Multiplication();
        break;
    case "/":
        maCalc.Division();
        break;
    case "%":
        maCalc.Modulo();
        break;
    default:
        Console.WriteLine("Opérateur incorrect");
        break;
}

Console.WriteLine($"Résultat : {maCalc.Resultat}");
