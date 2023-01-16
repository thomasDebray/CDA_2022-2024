// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * L’utilisateur est invité à saisir 2 nombres entier.
 * Le programme calcule la moyenne des 2 nombres et 
 * affiche le résultat sous forme de nombre réel double précision.
*/

/*
 * DECLARATION DES VARIABLES
 * 
 * NB1 EST UN ENTIER 
 * NB2 EST UN ENTIER
 * RESULT EST UN REEL
 * userInput est une chaine
 * 
 * TRAITEMENT 
 * 
 * ECRIRE "Programme de calcul de moyenne de 2 nombres"
 * ECRIRE "Veuillez saisir le nombre 1"
 * LIRE userInput
 * CONVERTIR userInput en entier vers NB1
 * ECRIRE "Veuillez saisir le nombre 2"
 * LIRE userInput
 * CONVERTIR userInput en entier vers NB2 
 * 
 * RESULT <-- (NB1 + NB2) / 2
 * RESULT := (NB1 + NB2) / 2
 * 
 * AFFICHAGE du/des RESULTAT(S)
 * 
 * ECRIRE "La moyenne de ", NB1 ," et ", NB2 ," est de: ", RESULT
*/
try
{
    int nb1;
    int nb2;
    double result;
    string userInput;
    Console.WriteLine("Programme de calcul de moyenne de 2 nombres");

    Console.WriteLine("Veuillez saisir le nombre 1");
    userInput = Console.ReadLine();
    nb1 = Int32.Parse(userInput);

    Console.WriteLine("Veuillez saisir le nombre 2");
    userInput = Console.ReadLine();
    nb2 = Convert.ToInt32(userInput);
    //nb2 = int.Parse(Console.ReadLine());

    result = (nb1 + nb2) / 2d;

    Console.WriteLine("La moyenne de " + nb1 + " et " + nb2 + " est de: " + result);
    Console.ReadLine();
}
catch
{
    Console.WriteLine("Erreur de saisie ! ");
    Console.ReadLine();
}