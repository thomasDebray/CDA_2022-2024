/*
 * L'utilisateur est invité à entrer une phrase et le programme détermine si c'est un palindrome ou non.
 * Le programme peut afficher un des trois cas :
 *      - la phrase est vide
 *      - la chaîne de caractère n'est pas un palindrome
 *      - la chaîne de caractère est un palindrome
 *      
 * DECLARATION DE VARIABLE
 * 
 * phrase est une chaîne
 * phraseAlEndroit est une lise de char
 * phraseAlEnvers est une liste de char
 * 
 * TRAITEMENT ET RESULTAT
 * 
 * FAIRE
 *      ECRIRE "Veuillez entrer une phrase :"
 *      LIRE phrase
 *          SI phrase.count <2 ALORS
 *              ECRIRE "la phrase est vide"
 *          FINSI
 * TANTQUE phrase.count <2
 * FINTANTQUE
 * FOR i=phrase.lenght i>-1 i--
 *      SI phrase[i] =* ' ' ALORS
 *      Ajouter à phraseAlEnvers phrase[i]
 *      FINSI
 * FINFOR
 * FOR j=0 j <phrase.lenght j++
 *      SI phrase[i] =* ' ' ALORS
 *      Ajouter à phraseAlEndroit phrase[i]
 *      FINSI
 * FINFOR
 * SI phraseAlEndroit == phraseAlEnvers ALORS
 *      ECRIRE "la chaîne de caractère est un palindrome"
 * SINON
 *      ECRIRE "la chaîne de caractère n'est pas un palindrome"
 */

string phrase;
List<char> phraseAlEndroit = new List<char>();
List<char> phraseAlEnvers = new List<char>();

do
{
    Console.WriteLine("Veuillez entrer une phrase :");
    phrase = Console.ReadLine();
    if (phrase.Length <2)
    {
        Console.WriteLine("la phrase est vide");
    }
} while (phrase.Length < 2);
for (int i = phrase.Length-1; i >-1; i--)
{
    if (phrase[i] != ' ')
    {
        phraseAlEnvers.Add(phrase[i]);
    }
}
for (int j = 0; j < phrase.Length; j++)
{
    if (phrase[j] != ' ')
    {
        phraseAlEndroit.Add(phrase[j]);
    }
}
if (phraseAlEndroit.SequenceEqual(phraseAlEnvers))
{
    Console.WriteLine("la chaîne de caractère est un palindrome");
}
else
{
    Console.WriteLine("la chaîne de caractère n'est pas un palindrome");
}
   

