/*
 * Le premier joueur entre un mot d'une longueur minimum de 5 caractères.
 * Le programme affiche le mot où toutes les lettres sauf la première et la dernière sont remplacées par un tiret.
 * Le deuxième joueur est invité à reconstituer en proposant des lettres une à une.
 * Il a droit à 6 erreurs.
 * 
 * DECLARATION DE VARIABLE
 * 
 * motATrouver est une chaîne
 * motCache est une chaîne
 * lettreProposee est un char
 * erreur est un entier
 * lettreTrouvee est un entier
 * 
 * TRAITEMENT
 * 
 * FAIRE
 *      ECRIRE "Joueur 1, veuillez entrer un mot d'une longueur minimum de 5 caractères :"
 *      LIRE motATrouver 
 * TANTQUE motATrouver.Lenght <5
 * FINFAIRETANTQUE
 * Clear console
 * motCache <-- motATrouver
 * FOR i=1; i<motCache-1; i++
 *      motCachee[i] <-- '-'
 * FINFOR
 * FAIRE
 *      ECRIRE motCache
 *      ECRIRE "Joueur 2, veuillez entrer une lettre :"
 *      LIRE lettreProposee
 *      lettreTrouvee <-- 0
 *      FOR i=1; i<motCache-1; i++
 *          SI lettreProposee == motATrouver[i] ALORS
 *              motCachee[i] <-- lettreProposee
 *              lettreTrouvee ++
 *          FINSI
 *      FINFOR
 *      SI lettreTrouvee == 0 ALORS
 *          erreur ++   
 * TANTQUE erreur <6
 */

string motATrouver;
string motCachee;
List<char> motCacheeList = new List<char>();
char lettreProposee;
int erreur=0;
int lettreTrouvee;

Console.Title = "Jeu du pendu";

do
{
    Console.WriteLine("Joueur 1, veuillez entrer un mot d'une longueur minimum de 5 caractères :");
    motATrouver = Console.ReadLine();
} while (motATrouver.Length <5);
Console.Clear();
for (int i = 0; i < motATrouver.Length; i++)
{
    motCacheeList.Add(motATrouver[i]);

}
for (int i = 1; i < motCacheeList.Count-1; i++)
{
    motCacheeList[i] = '-';
}
do
{
    Console.Clear();
    for (int i = 0; i < motCacheeList.Count; i++)
    {
        Console.Write(motCacheeList[i]);
    }

    Console.WriteLine("\nJoueur 2, veuillez entrer une lettre :");
    lettreProposee = Console.ReadKey().KeyChar;
    lettreTrouvee = 0;
    for (int i = 1; i < motCacheeList.Count-1; i++)
    {
        if (lettreProposee==motATrouver[i])
        {
            motCacheeList[i] = lettreProposee;
            lettreTrouvee++;
        }
    }
    if (lettreTrouvee==0)
    {
        erreur++;
    }
} while (erreur<6&&!(motCacheeList.SequenceEqual(motATrouver)));
if (erreur ==6)
{
    Console.Clear();
    Console.WriteLine("Vous avez perdu !");
}
if (motCacheeList.SequenceEqual(motATrouver))
{
    Console.Clear();
    for (int i = 0; i < motCacheeList.Count; i++)
    {
        Console.WriteLine(motCacheeList[i]);
    }
    Console.WriteLine("Vous avez gagné !");
}