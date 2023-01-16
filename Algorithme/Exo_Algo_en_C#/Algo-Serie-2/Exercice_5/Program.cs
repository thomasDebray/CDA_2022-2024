/*
 * L'utilisateur est invité à entrer un nombre.
 * Le programme va chercher l'ensemble des déviseurs autre que 1 et ce nombre puis les afficher.
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un reel
 * i est un entier
 * r est un entier
 * ECRIRE "Le programme recherche les diviseurs d'un nombre"
 * 
 * TRAITEMENT ET RESULTAT
 * 
 * ECRIRE "Veuillez entrer un nombre entier :"
 * LIRE entree
 * Convertir entree en entier vers a
 * i = 1
 * ECRIRE "Les diviseurs sont :"
 * REPETER
 *      i = n + 1
 *      r = a % i
 *      SI r = 0 ALORS
 *          ECRIRE i
 *      FINSI
 * JUSQU'A i = a-1
 */
int a;
string entree;
int i;
int r;
Console.WriteLine("Le programme recherche les diviseurs d'un nombre");

Console.WriteLine("Veuillez entrer un nombre entier :");
entree = Console.ReadLine();
a = int.Parse(entree);

Console.WriteLine("Les diviseurs autre que 1 et lui-même sont :");

for (i = 2; i < a-1; i++)
{
    r = a % i;
    if (r==0)
    {
        Console.WriteLine(i);
    }
}
