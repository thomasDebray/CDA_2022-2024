// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * L'utilisateur est invité à entrer un rayon et un angle.
 * Le programme calcule la surface d'un secteur circulaire et 
 * affiche le résultat en un réel double précision.
 */

/*
 * DECLARATION DES VARIABLE
 * 
 * r est un double
 * a est un double
 * aire est un double
 * entree est une chaine
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Veuillez saisir la valeur du rayon :"
 * LIRE entree
 * CONVERTIR entree en double vers r
 * ECRIRE "Veuillez entrer la valeur de l'angle (en degrée) :"
 * LIRE entree
 * CONVERTIR entree en double vers a
 * 
 * aire <-- (PI*r^2*a)/360
 * 
 * AFFICHAGE DU RESULTAT
 * 
 * ECRIRE "L'aire du secteur circulaire est :"+ aire +"."
 */
try
{
    double r;
    double a;
    double aire;
    string entree;
    Console.WriteLine("Programme de calcul de surface d'un secteur circulaire");

    Console.WriteLine("Veuillez saisir la valeur du rayon :");
    entree = Console.ReadLine();
    r = double.Parse(entree);
    Console.WriteLine("Veuillez entrer la valeur de l'angle (en degrée) :");
    entree = Console.ReadLine();
    a = double.Parse(entree);

    aire = (Math.PI * Math.Pow(r, 2) * a) / 360;

    Console.WriteLine("L'aire du secteur circulaire est :" + aire + ".");
    Console.ReadLine();
}
catch
{
    Console.WriteLine("Erreur de saisie");
    Console.ReadLine();
}