/*
 * L'utilisateur est invité à entrer deux nombres, le programme effectue un tri croissant puis
 * affiche les nombres dans l'ordre croissant.
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un reel
 * b est un reel
 * temp est un reel
 * entree est un string
 * ECRIRE "Programme de tri par ordre croissant"
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Veuillez entrer un premier nombre :"
 * LIRE temp
 * Convertir temp en reel vers a
 * ECRIRE "Veuillez entrer un deuxième nombre :"
 * LIRE temp
 * Convertir temp en reel vers b
 * SI a>b ALORS
 *      temp <--a
 *      a <-- b
 *      b <-- temp
 * FINSI
 * 
 * RESULTAT
 * 
 * ECRIRE "Les nombres par ordre croissant sont :"
 * ECRIRE a, " ", b
 */
float a;
float b;
float temp;
string entree;
Console.WriteLine("Programme de tri par ordre croissant");

Console.WriteLine("Veuillez entrer un premier nombre :");
entree = Console.ReadLine();
a = float.Parse(entree);
Console.WriteLine("Veuillez entrer un deuxième nombre :");
entree = Console.ReadLine();
b = float.Parse(entree);
if (a>b)
{
    temp = a;
    a = b;
    b = temp;
}
Console.WriteLine("Les nombres par ordre croissant sont :");
Console.WriteLine(a + " et " + b);
