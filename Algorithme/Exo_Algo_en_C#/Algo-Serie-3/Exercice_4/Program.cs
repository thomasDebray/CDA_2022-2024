/*
 * L'utilisateur entre une chaîne de caractère et une lettre,
 * le programme cherche le nombre de fois où apparait la lettre dans la chaîne.
 * Ensuite le programme affiche 3 cas possibles :
 * - la phrase est vide
 * - la lettre n'est pas présente
 * - la lettre est présente une ou plusieurs fois
 * 
 * DECLARATION DE VARIABLE
 * 
 * phrase est une chaîne
 * lettre est un charactère
 * compteur est un entier
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Veuillez entrer une phrase terminant par un point :"
 * LIRE phrase
 * ECRIRE "Veuillez entrer une lettre qui sera recherché dans la phrase."
 * LIRE lettre
 * 
 * SI la longueur de la phrase est egale à 0 OU le tableau à l'indice 0 == '.'
 *   ECRIRE "LA CHAINE EST VIDE"
 * SINON
 *   POUR i de 0 jusqu'a longueur du tableau avec un pas de 1
 *        SI phrase de i égale lettre
 *            faire compteur ++
 *        FINSI
 *   SI compteur == 0
 *        ECRIRE "LA LETTRE N'EST PAS PRESENTE"
 *   SINON
 *        ECRIRE "LA LETTRE EST PRESENTE UNE OU PLUSIEURS FOIS"
 * FINSI
 */

string phrase;
char lettre;
int compteur = 0;

Console.WriteLine("Veuillez entrer une phrase terminant par un point :");
phrase = Console.ReadLine().ToLower();


if (phrase.Length == 0 || phrase[0] == '.')
{
    Console.WriteLine("LA CHAINE EST VIDE");
}
else
{
    Console.WriteLine("Veuillez entrer une lettre qui sera recherché dans la phrase.");
    lettre = Console.ReadKey().KeyChar;
    for (int i = 0; i < phrase.Length; i++)
    {
        if (phrase[i] == lettre)
        {
            compteur++;
        }
    }
    if (compteur == 0)
    {
        Console.WriteLine("LA LETTRE N'EST PAS PRESENTE");
    }
    else
        Console.WriteLine("LA LETTRE EST PRESENTE "+compteur+" FOIS");
}





