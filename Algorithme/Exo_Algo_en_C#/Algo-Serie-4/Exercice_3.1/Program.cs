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
