/*
 * L'utilisateur est invité à entrer l'âge de 20 personnes.
 * Le programme calcule le nombre de jeune (< 20 ans) et affiche le nombre.
 * 
 * DECLARATION DE VARIABLE
 * 
 * input est une chaîne
 * listJeune est une liste d'entier
 * ageJeune est un float
 * 
 * TRAITEMENT
 * 
 * FOR (i=0;i<20;i++)
 *      ECRIRE "Veuillez entrer l'âge de la personne n°", i+1," :"
 *      LIRE input
 *      SI essayer convertir en float input vers ageJeune && ageJeune<20 && ageJeune>0 ALORS
 *          ajouter ageJeune à listJeune
 *      FINSI
 * FINFOR
 * 
 * RESULTAT
 * 
 * ECRIRE "Le nombre de jeune est de ", compte de listJeune
 */

string input;
List<float> listJeune = new List<float>();
float ageJeune = 0;

for (int i = 0; i < 20; i++)
{
    do
    {
        Console.WriteLine("Veuillez entrer l'âge de la personne n°" + (i + 1) + " :");
        input = Console.ReadLine();
        if (float.TryParse(input, out ageJeune) && ageJeune < 20 && ageJeune > 0)
        {
            listJeune.Add(ageJeune);
        }
    } while (!(float.TryParse(input, out ageJeune) && ageJeune < 20 && ageJeune > 0));
    
}
Console.WriteLine("Le nombre de jeune est de " + listJeune.Count);
