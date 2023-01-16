/*
 * L'utilisateur est invité à entrer trois nombres, le programme effectue un tri croissant puis
 * affiche les nombres dans l'ordre croissant.
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un reel
 * b est un reel
 * c est un reel
 * temp est un reel
 * entree est une chaine
 * ECRIRE "Programme de tri par ordre croissant"
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Veuillez entrer un premier nombre :"
 * LIRE entree
 * Convertir entree en reel vers a
 * ECRIRE "Veuillez entrer un deuxième nombre :"
 * LIRE entree
 * Convertir entree en reel vers b
 * ECRIRE "Veuillez entrer un troisième nombre :"
 * LIRE entree
 * Convertir entree en reel vers c
 * 
 * TANTQUE non(a<=b && b<=c)
 *      SI a>b ALORS
 *          temp <-- a
 *          a <-- b
 *          b <-- temp
 *      FINSI
 *      SI b>c ALORS
 *          temp <-- b
 *          b <-- c
 *          c <-- temp
 *      FINSI
 * FINTANTQUE
 * 
 * RESULTAT
 * 
 * ECRIRE "Les nombres par ordre croissant sont :"
 * ECRIRE a,", ", b ," et ", c
 */

float a;
float b;
float c;
float temp;
string entree;
Console.WriteLine("Programme de tri par ordre croissant");

Console.WriteLine("Veuillez entrer un premier nombre :");
entree = Console.ReadLine();
a = float.Parse(entree);
Console.WriteLine("Veuillez entrer un deuxième nombre :");
entree = Console.ReadLine();
b = float.Parse(entree);
Console.WriteLine("Veuillez entrer un troisième nombre :");
entree = Console.ReadLine();
c = float.Parse(entree);

while (!(a<=b && b<=c))
{
    if (a>b)
    {
        temp = a;
        a = b;
        b = temp;
    }
    if (b>c)
    {
        temp = b;
        b = c;
        c = temp;
    }
}

Console.WriteLine("Les nombres par ordre croissant sont :");
Console.WriteLine(a + ", " + b + " et " + c);