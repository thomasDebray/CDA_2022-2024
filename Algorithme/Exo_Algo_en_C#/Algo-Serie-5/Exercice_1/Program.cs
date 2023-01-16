/*
 * L'utilisateur est invité à entrer des noms de légumes en précisant chaque fois un prix au kilo.
 * Quand l'utilisateur entre "go", le programme cherche le légume avec le prix au kilo le moins cher.
 * A la fin, le programme affiche le légume le moins cher au kilo.
 * 
 * DECLARATION DE VARIABLE
 * 
 * listLegume est une liste de string
 * listPrix est une liste de float
 * input est un string
 * tableauInput est un tableau de string
 * prixLegume est un float
 * indexPrixMin = 0 est entier
 * 
 * TRAITEMENT
 * 
 * FAIRE
 *      ECRIRE "Veuillez saisir un nom de légume en précisant son prix au kilo (ex : carottes 2,99) ou go :"
 *      LIRE input
 *      tableauInput = split ' ' de input
 *      add listLegume (tableauInput[0])
 *      add listPrix (tableauInput[1])
 * TANT QUE !tableauInput[0] == go
 * 
 * FOR (i = 0, i < listPrix.lenght, i ++)
 *      SI listPrix[i]<listPrix[indexPrixMin] ALORS
 *          indexPrixMin = i
 * 
 * RESULTAT
 * 
 * ECRIRE "Légume le moins cher au kilo : ", listLegume[indexPrixMin] 
 */

List<string> listLegume = new List<string>();
List<float> listPrix = new List<float>();
string input;
string[] tableauInput;
float prixLegume;
int indexPrixMin = 0;

do
{
    Console.WriteLine("Veuillez saisir un nom de légume en précisant son prix au kilo (ex : carottes 2,99) ou go :");
    input = Console.ReadLine().ToLower();
    tableauInput = input.Split(' ');
    if (tableauInput.Length == 2 && float.TryParse(tableauInput[1],out prixLegume ))
    {
        listLegume.Add(tableauInput[0]);
        listPrix.Add(prixLegume);
    }
    
} while (!(input=="go"));

for (int i = 0; i < listPrix.Count; i++)
{
    if (listPrix[i]<listPrix[indexPrixMin])
    {
        indexPrixMin = i;
    }
}

Console.WriteLine("Légume le moins cher au kilo : " + listLegume[indexPrixMin]);