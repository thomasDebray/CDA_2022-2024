/*
 * L'utilisateur est invité à entrer le nombre de consommateur intérogé pour leur couleur préféré
 * entre 500 et 5000.
 * Le programme simule le résultat de l'étude puis détermine les deux couleurs les plus demandées.
 * Le programme affiche en résultat les deux couleurs les plus demandées.
 *
 * DECLARATION DE VARIABLE
 *
 * listCouleur est une liste de string <-- {"rouge","jaune","bleu"}
 * listTotalCouleur est une liste d'entier à 3 colonnes
 * indexMax est un entier
 * premiereCouleur est un string
 * deuxiemeCouleur est un string
 * 
 * 
 * TRAITEMENT
 * 
 * 
 * 
 * méthode App.run (results : array) : string
 *      POUR i de 0 à listCouleur.Count i++
 *          POUR j de 0 à results.Count j++
 *              SI listCouleur[i]==results[j] ALORS
 *                  listTotalCouleur[i] ++
 *              FINSI
 *          FINPOUR
 *      FINPOUR
 *      
 *      indexMax <-- 0
 *      POUR k de 0 à listTotalCouleur.Count et k++
 *          SI listTotalCouleur[k] > listTotalCouleur[indexMax] ALORS
 *              indexMax <-- k
 *      FINPOUR
 *      premiereCouleur <-- listCouleur[indexMax]
 *      remove listTotalCouleur[indexMax] de listTotalCouleur
 *      remove listCouleur[indexMax] de listCouleur
 *      
 *      indexMax <-- 0
 *      POUR k de 0 à listTotalCouleur.Count et k++
 *          SI listTotalCouleur[k] > listTotalCouleur[indexMax] ALORS
 *              indexMax <-- k
 *      FINPOUR
 *      deuxiemeCouleur <-- listCouleur[indexMax]
 *      
 *      return premiereCouleur+" "+deuxiemeCouleur
 */


using System.Net.Http.Headers;
using System.Text.Json;
using Yaourts;

//Yoghurt yg = loadFromFile("input.json");

HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
var content = await client.GetStringAsync("https://api.devoldere.net/polls/yoghurts/");
string flux = Convert.ToString(content);
Yoghurt yg = JsonSerializer.Deserialize<Yoghurt>(flux);

Console.WriteLine(Run(yg.results));

Yoghurt? loadFromFile(string filePath)
{
    string text;
    text = File.ReadAllText(filePath);
    Yoghurt loadFrom = JsonSerializer.Deserialize<Yoghurt>(text);
    return loadFrom;
}

static string Run (List<string> results)
{
    List<string> listCouleur = new List<string>();
    listCouleur.Add("red");
    listCouleur.Add("orange");
    listCouleur.Add("yellow");
    listCouleur.Add("blue");

    List<int> listTotalCouleur = new List<int>();
    for (int i = 0; i < listCouleur.Count; i++)
    {
        listTotalCouleur.Add(0);
    }
     
    int indexMax;
    string premiereCouleur;
    string deuxiemeCouleur;

    for (int i = 0; i < listCouleur.Count; i++)
    {
        for (int j = 0; j < results.Count; j++)
        {
            if (listCouleur[i]==results[j])
            {
                listTotalCouleur[i]++;
            }
        }
    }
    
    indexMax = 0;
    for (int k = 0; k < listTotalCouleur.Count; k++)
    {
        if (listTotalCouleur[k]>listTotalCouleur[indexMax])
        {
            indexMax = k;
        }
    }
    premiereCouleur = listCouleur[indexMax];
    listCouleur.Remove(listCouleur[indexMax]);
    listTotalCouleur.Remove(listTotalCouleur[indexMax]);

    indexMax = 0;
    for (int k = 0; k < listTotalCouleur.Count; k++)
    {
        if (listTotalCouleur[k] > listTotalCouleur[indexMax])
        {
            indexMax = k;
        }
    }
    deuxiemeCouleur = listCouleur[indexMax];

    return premiereCouleur + " " + deuxiemeCouleur;

}
