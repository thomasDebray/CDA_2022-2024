/*
 * L'utilisateur est invité à entrer le nombre de nombre parfait qu'il souhaite obtenir
 * Le programme calcule la valeur des nombres parfaits et les affiche.
 * 
 */


Console.WriteLine("Combien de nombre parfait voulez-vous ?");
string entree = Console.ReadLine();
int parfaitAObtenir = int.Parse(entree);
afficherParfait(parfaitAObtenir);
/* CETTE METHODE LISTE L'ENSEMBLE DES DIVISEURS DU NOMBRE N (1 et N exclus) */
static List<int> listerDiviseur(int n)
{
    List<int> rt = new List<int>();
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
            rt.Add(i);
    }
    return rt;
}

static bool estParfait(int n)
{
    int sommeDiviseur = 1;
    List<int> diviseurs = listerDiviseur(n);
    for (int i = 0; i < diviseurs.Count; i++)
    {
        sommeDiviseur += diviseurs[i];
    }
    return sommeDiviseur == n;
}


static bool estPremier(int n)
{
    return listerDiviseur(n).Count == 0;
}

static void afficherParfait(int nbDeParfait)
{
    int nombreDeParfaitTrouve = 0;
    int nombreTeste = 2;
    while (nombreDeParfaitTrouve<nbDeParfait)
    {
        if (estParfait(nombreTeste))
        {
            Console.WriteLine(nombreTeste + " est un nombre parfait.");
            nombreDeParfaitTrouve++;
        }
        nombreTeste++;
    }

}