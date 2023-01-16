/*string uniteDeMesure;
string userInput=".";
string[] userInputTable;
double userInputConvert = 0;
double result;
string commandeDeSortie = "quit";

do
{
    Console.WriteLine("Veuillez saisir une unité de mesure (C ou F) ou quit :");
    uniteDeMesure = Console.ReadLine();

    if (uniteDeMesure=="F")
    {
        Console.WriteLine("Veuillez entrer deux valeurs min et max d'une plage :");
        userInputTable = userInput.Split(' ');
    }

    if (double.TryParse(userInputTable[0], out userInputConvert) && userInputConvert >= -459.67 && userInputConvert <= 5000000)
    {

        if (userInputTable[1] == "F")
        {
            result = (userInputConvert - 32d) * (5d / 9);
            Console.WriteLine("Le resultat est " + result + " °C.");
        }
        if (userInputTable[1] == "C")
        {
            result = (userInputConvert * (9d / 5)) + 32d;
            Console.WriteLine("Le resultat est " + result + " °F.");
        }
    }
}
while (!uniteDeMesure.Equals(commandeDeSortie));*/
string input;
char uniteMesure = ' ';
string[] tableauPlageValeur;
double[] valeurConvertie = new double[2];

// ON RECUPERE L'UNITE DE MESURE QUI SERVIRA LA CONVERSION
do
{
    Console.WriteLine("Veuillez saisir une unité de mesure (C ou F) ou quit :");
    input = Console.ReadLine();
    bool plageCorrecte = false;
    while (!input.Equals("quit") && !plageCorrecte)
    {
        uniteMesure = input[0];
        Console.WriteLine("Veuillez entrer une plage de valeur à convertir espacé par un espace (ex: \"32 35\")");
        input = Console.ReadLine();
        tableauPlageValeur = input.Split(' ');
        if (tableauPlageValeur.Length == 2)
        {
            valeurConvertie = arrayStringToDouble(tableauPlageValeur);
            plageCorrecte = rangeIsOk(valeurConvertie, uniteMesure);

        }
    }
    if (!input.Equals("quit"))
    {
        convertirPlage(valeurConvertie[0], valeurConvertie[1], uniteMesure);
    }
} while (!input.Equals("quit"));

static double[] arrayStringToDouble(string[] valeursAConvertir)
{
    double[] valeurConvertie = new double[valeursAConvertir.Length];
    for (int i = 0; i < valeursAConvertir.Length; i++)
    {
        valeurConvertie[i] = double.Parse(valeursAConvertir[i]);
    }
    return valeurConvertie;
}

static double convertToFahrenheit(double celcius)
{
    return celcius * (9d / 5) + 32;
}

static double convertToCelcius(double fahrenheit)
{
    return (fahrenheit - 32) * (5d / 9);
}

static void convertirPlage(double min, double max, char uniteDeMesure)
{
    double minConverti, maxConverti;

    if (uniteDeMesure=='C')
    {
        minConverti = convertToFahrenheit(min);
        maxConverti = convertToFahrenheit(max);
    }
    else
    {
        minConverti = convertToCelcius(min);
        maxConverti = convertToCelcius(max);
    }
    Console.WriteLine(String.Format("La plage comprise entre {0} et {1} °{2} est de {3} à {4} °{5}",
        min, max, uniteDeMesure, minConverti, maxConverti, (uniteDeMesure == 'C' ? 'F' : 'C')));
}

static bool valueIsOnRange(double val, char unite)
{
    if (unite == 'C')
    {
        //return rangeIsOk(convertToFahrenheit(val), 'F');
        return val >= -273.15 && val <= 2777760.372;
    } else
    {
        return val >= -459.67 && val <= 5000000;
    }
}


static bool rangeIsOk(double[] val, char unite)
{
    bool rt = true;
    int i = 0;
    while (rt && i < val.Length)
    {
        rt = valueIsOnRange(val[i], unite);
        i++;
    }
    return rt;
}