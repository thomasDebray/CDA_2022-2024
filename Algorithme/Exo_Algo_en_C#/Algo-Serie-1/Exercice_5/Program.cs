// See https://aka.ms/new-console-template for more information
/*
 * L'utilisateur est invité à entrer un premier nombre puis un deuxième nombre.
 * Le programme intervertis ces deux nombres puis les affiche.
 * 
 * DECLARATION DE VARIABLE
 * 
 * a est un reel
 * b est un reel
 * temp est un reel
 * entree est un string
 * ECRIRE "Programme qui interverti deux nombres"
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Entrez la valeur de a :"
 * LIRE entree
 * Convertir entree en reel vers a
 * ECRIRE  "Entrez la valeur de b :"
 * LIRE entree
 * Convertir entree en reel vers b
 * 
 * ECRIRE "a vaut ", a ," et b vaut ", b
 * 
 * temp <-- a
 * a <-- b
 * b <-- temp
 * 
 * RESULTAT
 * 
 * ECRIRE "a vaut ", a ," et b vaut ", b
 */

float a;
float b;
float temp;
string entree;
Console.WriteLine("Programme qui interverti deux nombres");

Console.WriteLine("Entrez la valeur de a :");
entree = Console.ReadLine();
a = float.Parse(entree);
Console.WriteLine("Entrez la valeur de b :");
entree = Console.ReadLine();
b = float.Parse(entree);

Console.WriteLine("a vaut "+ a +" et b vaut "+ b);

temp = a;
a = b;
b = temp;

Console.WriteLine("Maintenant, a vaut " + a + " et b vaut " + b);
