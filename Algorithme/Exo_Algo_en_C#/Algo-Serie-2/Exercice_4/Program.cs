/*
 * L'utilisateur est invité à entrer une année.
 * Le programme détermine si c'est une année bissextile ou non et affiche le résultat. 
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un entier
 * entree est une chaine
 * r1 est un entier
 * r2 est un entier
 * r3 est un entier
 * ECRIRE "Programme qui determine si une année est bissextile"
 * 
 * TRAITEMENT ET RESULTAT
 * 
 * ECRIRE "Veuillez entrer une année :"
 * LIRE entree
 * Convertir entree en entier vers a
 * r1 <-- a%4
 * r2 <-- a%100
 * r3 <-- a%400
 * SI r1 != 0 ALORS
 *      ECRIRE "L’année n’est pas bissextile"
 * SINON
 *      SI r2 = 0 && r3 != 0 ALORS
 *          ECRIRE "L’année n’est pas bissextile"
 *      SINON
 *          ECRIRE "L’année est bissextile"
 *      FINSI
 * FINSI
 */

int a;
string entree;
int r1;
int r2;
int r3;
Console.WriteLine("Programme qui determine si une année est bissextile");

Console.WriteLine("Veuillez entrer une année :");
entree = Console.ReadLine();
a = int.Parse(entree);
r1 = a % 4;
r2 = a % 100;
r3 = a % 400;
if (r1 != 0)
{
    Console.WriteLine("L’année n’est pas bissextile");
}
else
{
    if (r2 == 0 && r3 != 0)
    {
        Console.WriteLine("L’année n’est pas bissextile");
    }
    else
    {
        Console.WriteLine("L’année est bissextile");
    }
}
