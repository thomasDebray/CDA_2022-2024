/*
 * L'utilisateur est invité à entrer son age et le programme indique son statut.
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un entier
 * entree est une chaine
 * ECRIRE "Programme qui indique votre statut suivant votre age"
 * 
 * TRAITEMENT ET RESULTAT
 * 
 * ECRIRE "Veuillez entrer votre âge (en années) :"
 * LIRE entree
 * Convertir entree en entier vers a
 * 
 * SI a >= ALORS
 *      SI a < 18 ALORS
 *          ECRIRE "Vous êtes mineur"
 *      SINON
 *          ECRIRE "Vous êtes majeur"
 *      FINSI
 * SINON
 *      ECRIRE "Vous n'êtes pas encore né"
 * FINSI
 */
int a;
string entree;
Console.WriteLine("Programme qui indique votre statut suivant votre âge");

Console.WriteLine("Veuillez entrer votre âge (en années) :");
entree = Console.ReadLine();
a = int.Parse(entree);

if (a>=0)
{
    if (a<18)
    {
        Console.WriteLine("Vous êtes mineur");
    }
    else
    {
        Console.WriteLine("Vous êtes majeur");
    }
}
else
{
    Console.WriteLine("Vous n'êtes pas encore né");
}
