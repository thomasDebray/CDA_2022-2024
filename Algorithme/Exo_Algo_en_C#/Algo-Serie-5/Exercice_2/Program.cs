/*
 * A tour de rôle, l'ordinateur et l'utilisateur choisisse un nombre entre 0, 1 et 2.
 * Si la différence entre les nombres choisi vaut :
 * - 2 : le joueur qui a proposé le plus grand nombre gagne un point.
 * - 1 : le joueur qui a proposé le plus petit nombre gagne un point.
 * - 0 : aucun point n'est marqué.
 * Le jeu se termine quand un des deux joueurs (l'ordinateur ou le joueur humain) totalise 10 points ou quand l'être humain
 * introduit un nombre négatif qui indique sa volonté d'arrêter de jouer.
 * Dans les 2 cas, le programme affiche les scores.
 * 
 * DECLARATION DE VALEUR
 * 
 * tableauScore est un tableau avec entier
 * nombreUtilisateur est un entier
 * input est un string
 * nombreOrdinateur est un entier
 * 
 * TRAITEMENT
 * 
 * FAIRE
 *      ECRIRE "Veuillez choisir un nombre entre 0, 1 et 2 ou nombre négatif pour quitter :"
 *      LIRE input
 *      SI Essayer Convertir en entier input vers nombreUtilisateur && (nombreUtilisateur == 0 || nombreUtilisateur == 1 || nombreUtilisateur == 2) ALORS
 *          nombreOrdinateur <-- RANDOM
 *          SI |nombreUtilisateur - nombreOrdinateur|==2 ALORS
 *              SI nombreUtilisateur > nombreOrdinateur ALORS
 *                  tableauScore[0] ++
 *              SINON
 *                  tableauScore[1] ++
 *              FINSI
 *          SINON SI |nombreUtilisateur - nombreOrdinateur|==1 ALORS
 *              SI nombreUtilisateur < nombreOrdinateur ALORS
 *                  tableauScore[0] ++
 *              SINON
 *                  tableauScore[1] ++
 *          FINSI    
 *      FINSI
 * TANT QUE !nombreUtilisateur<0 && !(tableauScore[0]==10 || tableauScore[1]==10)
 * 
 * RESULTAT
 * 
 * ECRIRE "Vous avez ", tableauScore[0], " point(s) et l'ordinateur a ", tableauScore[1], " point(s)."
 */

int[] tableauScore = { 0, 0 };
int nombreUtilisateur = 0;
string input;

do
{
    Console.WriteLine("Veuillez choisir un nombre entre 0, 1 et 2 ou un nombre négatif pour quitter :");
    input = Console.ReadLine();
    if (int.TryParse(input,out nombreUtilisateur) && (nombreUtilisateur == 0 || nombreUtilisateur == 1 || nombreUtilisateur == 2))
    {
        Random rand = new Random();
        int nombreOrdinateur = rand.Next(0, 2);
        if (Math.Abs(nombreUtilisateur-nombreOrdinateur)==2)
        {
            if (nombreUtilisateur > nombreOrdinateur)
            {
                tableauScore[0]++;
            }
            else
                tableauScore[1]++;
        }
        else if (Math.Abs(nombreUtilisateur - nombreOrdinateur)==1)
        {
            if (nombreUtilisateur < nombreOrdinateur)
            {
                tableauScore[0]++;
            }
            else
                tableauScore[1]++;
        }
    }
} while (!(nombreUtilisateur<0 || (tableauScore[0]==10 || tableauScore[1]==10)));
Console.WriteLine("Vous avez " + tableauScore[0] + " point(s) et l'ordinateur a " + tableauScore[1] + " point(s)");

