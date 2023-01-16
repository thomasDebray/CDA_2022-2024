string userInput;
string[] userInputTable;
double userInputConvert = 0;
double result;
string commandeDeSortie = "quit";

do
{
    Console.WriteLine("Veuillez saisir une valeur numérique comprise entre -459.67 et 5000000 suivi de C pour Celsius ou F pour Fahrenheit :");
    userInput = Console.ReadLine();

    userInputTable = userInput.Split(' ');

    if (double.TryParse(userInputTable[0], out userInputConvert) && userInputConvert >= -459.67 && userInputConvert <= 5000000)
    {
        
        if (userInputTable[1] == "F")
        {
            result = (userInputConvert - 32d)*(5d/9);
            Console.WriteLine("Le resultat est " + result + " °C.");
        }
        if (userInputTable[1] == "C")
        {
            result = (userInputConvert * (9d/5))+32d;
            Console.WriteLine("Le resultat est " + result + " °F.");
        }
    }
}
while (!userInput.Equals(commandeDeSortie));

Console.ReadLine();
