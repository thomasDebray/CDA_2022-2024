// See https://aka.ms/new-console-template for more information
/*
 * Partie pseudo code
 * 
 * Déclaration de variable.
 * String userInput;
 * Double userInputConvert;
 * Double result;
 * Char commandeDeSortie = 'q';
 * 
 * AFFICHAGE
 * 
 * faire
 * 
 *      Ecrire ("Veuillez entrer une valeur à convertir en kilomètres comprise entre 0.01 et 1 000 000 ou saisir 'q' pour quitter le programme s'il vous plaît.")
 *      Lire userInput;
 *  
 *  si (userInput == 'q')
 *  Alors
 *      fin du programme
 * finsi
 *  
 * userInpuConvert <-- (double) userInput
 *  
 * Tant que (userInpuConvert < 0.01 || userInpuConvert >= 1 000 000)
 * 
 * 
 * TRAITEMENT
 * 
 * result <-- userInpuConvert / 1.609;
 * 
 * AFFICHAGE RESULTAT
 * 
 * Ecrire ("Le resultat est ", result," Miles.")
 * 
 * 
 */

string userInput;
string[] userInputTable;
double userInputConvert = 0;
double result;
string commandeDeSortie = "q";

do
{
    Console.WriteLine("Veuillez entrer une valeur à convertir comprise entre 0.01 et 1 000 000 avec km ou mi en unité ou saisir q pour quitter le programme :");
    userInput = Console.ReadLine().ToLower();

    userInputTable = userInput.Split(' ');
    
    if (double.TryParse(userInputTable[0], out userInputConvert) && userInputConvert >= 0.01 && userInputConvert < 1000000)
    {
        if (userInputTable.Count() > 1)
        {
            if (userInputTable[1] == "mi")
            {
                result = userInputConvert * 1.609;
                Console.WriteLine("Le resultat est " + result + " km.");
            }
            if (userInputTable[1] == "km")
            {
                result = userInputConvert / 1.609;
                Console.WriteLine("Le resultat est " + result + " mi.");
            }
        }
        if (userInputTable.Count() == 1)
        {
            result = userInputConvert / 1.609;
            Console.WriteLine("Le resultat est " + result + " mi.");
        }   
    }   
}
while (!userInput.Equals(commandeDeSortie));

Console.ReadLine();