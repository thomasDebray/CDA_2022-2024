/*
 * L'utilisateur est invité à entrer l'âge de 20 personnes.
 * Le programme calcule le nombre de jeune (< 20 ans), de non-jeune (> 20 ans) et égale à 20 ans.
 * Si toutes les personnes ont moins de 20 ans, le programme affiche « TOUTES LES PERSONNES ONT MOINS DE 20 ANS ».
 * Si aucune personne n'a moins de 20 ans, le programme affiche « TOUTES LES PERSONNES ONT PLUS DE 20 ANS ».
 * Sinon, il affiche le nombre de personnes pour chaque catégorie (« - de 20, + de 20, = à 20).
 * 
 * DECLARATION DE VARIABLE
 * 
 * input est une chaîne
 * listJeune est une liste de float
 * listNonJeune est une liste de float
 * list20Ans est une liste de float
 * age est un float
 * 
 * TRAITEMENT
 * 
 * FOR (i=0;i<20;i++)
 *      ECRIRE "Veuillez entrer l'âge de la personne n°", i+1," :"
 *      LIRE input
 *      SI essayer convertir en float input vers ageJeune && ageJeune<20 && ageJeune>0 ALORS
 *          ajouter ageJeune à listJeune
 *      FINSI
 *      SI
 *      FINSI
 *      SI
 *      FINSI
 * FINFOR
 * 
 * 
 * 
 * 
 * 
 * RESULTAT
 * 
 * ECRIRE "Le nombre de jeune est de ", compte de listJeune
 */

string input;
List<float> listJeune = new List<float>();
List<float> listNonJeune = new List<float>();
List<float> list20ans = new List<float>();
float age = 0;

for (int i = 0; i < 20; i++)
{
    do
    {
        Console.WriteLine("Veuillez entrer l'âge de la personne n°" + (i + 1) + " :");
        input = Console.ReadLine();
        if (float.TryParse(input, out age) && age < 20 && age > 0)
        {
            listJeune.Add(age);
        }
        if(float.TryParse(input, out age) && age >= 21)
        {
            listNonJeune.Add(age);
        }
        if(float.TryParse(input, out age) && age >=20 && age <21)
        {
            list20ans.Add(age);
        }
    } while (!(float.TryParse(input, out age) && age > 0));

}
if (listJeune.Count==20)
{
    Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
}
else if (listNonJeune.Count==20)
{
    Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
}
else
{
    Console.WriteLine("Le nombre de - de 20 est de " + listJeune.Count);
    Console.WriteLine("Le nombre de 20 ans est de " + list20ans.Count);
    Console.WriteLine("Le nombre de + de 20 est de " + listNonJeune.Count);
}
