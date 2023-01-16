/*
 * Le programme "choisit" aléatoirement un nombre mystère (entier compris entre 0 et 100)
 * L'utilisateur essaie de le deviner. A chaque essai le programme affiche la "fourchette"
 * dans laquelle se situe le nombre aléatoire.
 * Le programme affiche à la fin le nombre d'essais.
 * 
 * DECLARATION DE VARIABLE
 * 
 * n est un entier
 * nombreEssai est un entier
 * essai est un entier
 * entree est une chaîne
 * max est un entier
 * min est un entier
 * ECRIRE "Jeu de la fourchette"
 * 
 * TRAITEMENT
 * 
 * n <-- RANDOM(0,100)
 * nombreEssai <-- 0
 * FAIRE
 *      ECRIRE "Veuillez entrer un entier entre ",min," et ",max,"."
 *      LIRE entree
 *      Convertir en entier entree vers essai
 *      nombreEssai ++
 *      SI essai > n ALORS
 *          max <-- essai
 *      SINON
 *          min <-- essai
 *      FINSI
 * TANTQUE essai != n
 * 
 * RESULTAT
 * 
 * ECRIRE "Bravo vous avez trouvé en ", nombreEssai, " essai(s)."
 */

int nombreEssai;
int essai;
string entree = ".";
int max = 100;
int min = 0;
Console.WriteLine("Jeu de la fourchette");

Random rand = new Random();
int n = rand.Next(0,101);
nombreEssai = 0;
do
{
    while (!int.TryParse(entree,out essai) || essai<min || essai>max)
    {
        Console.WriteLine("Veuillez entrer un entier entre " + min + " et " + max + ".");
        entree = Console.ReadLine();
    }
    
    nombreEssai++;
    if (essai>n)
    {
        max = essai;
    }
    else
        min = essai;

    entree = ".";

} while (essai != n);

Console.WriteLine("Bravo vous avez trouvé en " + nombreEssai + " essai(s).");
