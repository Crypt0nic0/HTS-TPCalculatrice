using TPCalculatrice;

Console.WriteLine("======== CALCULATRICE ========");

Calculatrice maCalc = new Calculatrice();

Console.WriteLine("Veuillez saisir un premier chiffre : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez saisir un deuxièmre chiffre : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Saisir un opérateur entre + - * / % : ");
string op = Console.ReadLine();

int resu = 0;
switch (op)
{
    case "+":
        resu = maCalc.Addition(a, b);
        break;
    case "-":
        resu = maCalc.Soustraction(a, b);
        break;
    case "*":
        resu = maCalc.Multiplication(a, b);
        break;
    case "/":
        resu = maCalc.Division(a, b);
        break;
    case "%":
        resu = maCalc.Modulo(a, b);
        break;
    default:
        Console.WriteLine("Opérateur incorrect");
        break;
}

Console.WriteLine($"Résultat : {resu}");
