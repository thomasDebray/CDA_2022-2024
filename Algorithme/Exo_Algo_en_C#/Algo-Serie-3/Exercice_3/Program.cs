/*
 * L'utilisateur est invité à entrer une valeur et le programme va chercher dans un tableau de valeur si
 * elle présente ou pas.
 * Si elle trouve la valeur dans le tableau, le programme affiche l'indice correspondant sinon il affiche "404 Not found".
 * 
 *DECLARATION DE VARIABLE
 *
 *tableau est un tableau de nombres entier triés par ordre croissant
 *nombreCherche est un entier
 *entree est une chaîne
 *nombreTrouve est un booleen
 *ECRIRE "Rechercher un nombre dans un tableau"
 *
 *TRAITEMENT ET RESULTAT
 *
 *ECRIRE "Veuillez entrer un nombre entier à chercher :"
 *LIRE entree
 *Convertir entree en entier vers nombreCherche
 *nombreTrouve <-- false
 *POUR i de 0 jusqu'a longeur du tableau avec un pas de 1
 *      SI tableau[i] == nombreCherche
 *          ECRIRE "Le nombre cherché figure à l'indice ", i ,"."
 *          nombreTrouve <-- true
 *      FINSI
 *SI nombreTrouve == false
 *      ECRIRE "404 Not found"
 */
int[] tableau = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int nombreCherche;
string entree;
bool nombreTrouve;
Console.WriteLine("Rechercher un nombre dans un tableau");

Console.WriteLine("Veuillez entrer un nombre entier à chercher :");
entree = Console.ReadLine();
nombreCherche = int.Parse(entree);

nombreTrouve = false;
for (int i = 0; i < tableau.Length; i++)
{
    if (tableau[i] == nombreCherche)
    {
        Console.WriteLine("Le nombre cherché figure à l'indice " + i + ".");
        nombreTrouve = true;
    }
}
if (nombreTrouve == false)
{
    Console.WriteLine("404 Not found");
}