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
/*
string userInput;
double userInputConvert = 0;
double result;
string commandeDeSortie = "q";

do
{
    Console.WriteLine("Veuillez entrer une valeur à convertir en kilomètres comprise entre 0.01 et 1 000 000 ou saisir q pour quitter le programme s'il vous plaît.");
    userInput = Console.ReadLine();

    if (userInput.Equals(commandeDeSortie))
    {
        Environment.Exit(0);
    }

   // userInputConvert = double.Parse(userInput);

}
while (!double.TryParse(userInput, out userInputConvert) || userInputConvert < 0.01 || userInputConvert >= 1000000);

result = userInputConvert / 1.609;

Console.WriteLine("Le resultat est "+ result +" Miles.");
Console.ReadLine();
*/

// V2 : plusieurs conversions possibles

string userInput;
double userInputConvert = 0;
double result;
string commandeDeSortie = "q";

do
{
    Console.WriteLine("Veuillez entrer une valeur à convertir en kilomètres comprise entre 0.01 et 1 000 000 ou saisir q pour quitter le programme s'il vous plaît.");
    userInput = Console.ReadLine();

    if (double.TryParse(userInput, out userInputConvert) && userInputConvert >= 0.01 && userInputConvert < 1000000)
    {
        result = userInputConvert / 1.609;
        Console.WriteLine("Le resultat est " + result + " Miles.");
    }
}
while (!userInput.Equals(commandeDeSortie));


Console.ReadLine();
