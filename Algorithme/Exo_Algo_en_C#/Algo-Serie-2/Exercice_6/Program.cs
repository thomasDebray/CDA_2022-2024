/*
 * L'utilisateur est invité à entrer un nombre entier.
 * Le programme détermine si le nombre est premier ou non puis 
 * affiche le résultat.
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un entier
 * entree est une chaine
 * diviseurTrouve est un booleen
 * i est un entier
 * ECRIRE "Le programme détermine si un nombre est premier ou non"
 * 
 * TRAITEMENT ET RESULTAT
 * 
 * ECRIRE "Veuillez entrer un nombre entier :"
 * LIRE entree
 * Convertir entrer en entier vers a
 * diviseurTrouve <-- faux
 * i <-- 2
 * TANTQUE !diviseurTrouve && i<a-1
 *      divseurTrouve <-- a%i == 0
 *      i <-- i+1
 * FINTANTQUE
 * SI diviseurTrouve ALORS
 *      ECRIRE "Le nombre est premier"
 * SINON
 *      ECRIRE "Le nombre n'est pas premier"
 * FINSI
 */
int a;
string entree;
bool diviseurTrouve;
int i;
Console.WriteLine("Le programme détermine si un nombre est premier ou non");

Console.WriteLine("Veuillez entrer un nombre entier :");
entree = Console.ReadLine();
a = int.Parse(entree);

diviseurTrouve = false;
i = 2;
while (!diviseurTrouve && i<a-1)
{
    diviseurTrouve = a % i == 0;
    i++;
}
if (diviseurTrouve)
{
    Console.WriteLine("Le nombre n'est pas premier");
}
else
{
    Console.WriteLine("Le nombre est premier");
}
