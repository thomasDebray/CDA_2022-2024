/*
 * L'utilisateur est invité à entrer deux nombres entiers non nuls.
 * Le programme calcule le PGCD avec la méthode dite "égyptienne".
 * Le résultat est affiché après calcul.
 */

int p;
int q;
string input;

Console.Title = "Calcul du PGCD";

do
{
    Console.WriteLine("Veuillez entrer un premier nombre entier strictement positif :");
    input = Console.ReadLine();
} while (!(int.TryParse(input,out p) && p > 0));
do
{
    Console.WriteLine("Veuillez entrer un deuxième nombre entier strictement positif :");
    input = Console.ReadLine();
} while (!(int.TryParse(input, out q) && q > 0));

static int Calcul_PGCD(int a, int b)
{
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
            b = b - a;
    }
    return a;
}

Console.WriteLine("Le PGCD de " + p + " et " + q + " est : " + Calcul_PGCD(p, q) + ".");
