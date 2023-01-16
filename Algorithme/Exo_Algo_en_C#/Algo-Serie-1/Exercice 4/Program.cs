// See https://aka.ms/new-console-template for more information
/*
 * L'utilisateur est invité à entrer la somme placée sun un compte, l'intérêt offert par la banque et le nombre d'années de placement.
 * Le programme calcule l'intérêt simple et composé.
 * Il affiche en suite les résultats en euros.
 */
/*
 * DECLARATION DE VARIABLE
 * 
 * s est un reel
 * i est un reel
 * n est un reel
 * interetSimple est un reel
 * interetCompose est un reel
 * ECRIRE "Programme de calcul d'intérêts"
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Veuillez entrer la valeur de la somme placée :"
 * LIRE s
 * ECRIRE "Veuillez entrer la valeur de l'intérêt :"
 * LIRE i
 * ECRIRE "Veuillez entrer le nombre d'années :"
 * LIRE n
 * 
 * interetSimple <-- s*(1+n*(i/100))
 * interetCompose <-- s*(1+(i/100))^n
 * 
 * AFFICHAGE DES RESULTATS
 * 
 * ECRIRE "La valeur des intérêts simple est : ", interetSimple, "."
 * ECRIRE "La valeur des intérêts composés est : ", interetCompose, "."
 */

float s;
float i;
float n;
string entree;
float interetSimple;
double interetDouble;

Console.WriteLine("Programme de calcul d'intérêts");

Console.WriteLine("Veuillez entrer la valeur de la somme placée :");
entree = Console.ReadLine();
s = float.Parse(entree);
Console.WriteLine("Veuillez entrer la valeur de l'intérêt :");
entree = Console.ReadLine();
i = float.Parse(entree);
Console.WriteLine("Veuillez entrer le nombre d'années :");
entree = Console.ReadLine();
n = float.Parse(entree);

interetSimple = s * (1 + n * (i/100));
interetDouble = s * Math.Pow(1 + (i/100), n);

Console.WriteLine("La valeur des intérêts simple est : " + interetSimple + ".");
Console.WriteLine("La valeur des intérêts composés est : " + interetDouble + ".");
