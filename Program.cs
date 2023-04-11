using TPCalculatrice;

Console.WriteLine("======== CALCULATRICE ========");

Calculatrice maCalc = new Calculatrice();

Console.WriteLine("Veuillez saisir un premier chiffre : ");
maCalc.OperanteGauche = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez saisir un deuxièmre chiffre : ");
maCalc.OperanteDroite = int.Parse(Console.ReadLine());
Console.WriteLine();

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
