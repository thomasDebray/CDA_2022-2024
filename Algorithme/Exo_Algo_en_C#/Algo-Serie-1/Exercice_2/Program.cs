// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * L'utilisateur est invité à saisir un rayon.
 * Le programme calcule l'aire et le volume de la sphère et
 * affiche les résultats.
 */

/*
 * DECLARATION DES VARIABLES
 * 
 * R EST UN DOUBLE
 * AIRE EST UN DOUBLE
 * VOLUME EST UN DOUBLE
 * ENTREE EST UNE CHAINE
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Programme de calcul de l'aire et du volume d'une sphère"
 * ECRIRE "Veuillez entrer un rayon"
 * LIRE ENTREE
 * CONVERTIR ENTREE en float vers R
 * 
 * AIRE <-- 4*PI*R^2
 * VOLUME <-- (4/3)*PI*R^3
 * 
 * ECRIRE "Pour une shère de rayon "+ R +", son aire est de "+ AIRE +" et son volume est de "+ VOLUME +"."
 */
try
{
    double r;
    double aire;
    double volume;
    string entree;
    Console.WriteLine("Programme de calcul de l'aire et du volume d'une sphère.");

    Console.WriteLine("Veuillez entrer un rayon :");
    entree = Console.ReadLine();
    r = double.Parse(entree);

    aire = 4 * Math.PI * Math.Pow(r,2);
    volume = (4 / 3D) * Math.PI * Math.Pow(aire,3);

    Console.WriteLine("Pour une sphère de rayon " + r + ", son aire est de " + aire + " et son volume est de " + volume + ".");
    Console.ReadLine();
}
catch
{
    Console.WriteLine("Erreur de saisie");
    Console.ReadLine();
}