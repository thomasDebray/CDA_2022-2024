/*
 * L'utilisateur entre la somme initiale de Barnabe,
 * le programme va trouver le nombre de magasin dans lesquels Barnabe fait ses courses
 * puis affiche le nombre de magasin à l'utilisateur.
 * 
 * DECLARATION DE VARIABLE
 * 
 * sTemp est un entier
 * s est un reel
 * entree est une chaine
 * depense est un reel
 * nombreDeMagasin est un entier
 * course est un booleen
 * ECRIRE "Barnabe fait ses courses"
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Veuillez entrer la somme initiale de Barnabé pour faire les courses :"
 * LIRE entree
 * 
 * Vérifier et convertir entree en entier vers s
 * 
 * nombreDeMagasin <-- 0
 * WHILE course == true
 *      depense <-- (s/2)+1
 *      SI s-depense=>0 ALORS
 *          nombreDeMagasin ++
 *          s <-- s-depense
 *      SINONSI s >= 1
 *          nombreDeMagasin ++
 *          s <-- s - s
 *          course <-- false
 *      SINON
 *          course <-- false
 *      FINSI
 * FINWHILE
 *          
 * RESULTAT
 * 
 * ECRIRE "Barnabé à fait ses courses dans ", nombreDeMagasin, " magasins."
 */

int sTemp;
double s;
string entree=".";
//double depense;
//int nombreDeMagasin = 0;
//bool course = true;
Console.WriteLine("Barnabé fait ses courses");

while (!(int.TryParse(entree,out sTemp) && sTemp>1))
{
    Console.WriteLine("Veuillez entrer la somme initiale de Barnabé pour faire ses courses en un entier > à 1 :");
    entree = Console.ReadLine();
}
s = sTemp;

static int NombreDeMagasin(double  _sous)
{
    bool course = true;
    int nombreDeMagasin = 0;
    double depense;

    while (course == true)
    {
        depense = (_sous / 2) + 1;
        if (_sous - depense >= 0)
        {
            nombreDeMagasin++;
            _sous = _sous - depense;
        }
        else if (_sous >= 1)
        {
            nombreDeMagasin++;
            _sous = _sous - _sous;
            course = false;
        }
        else
            course = false;

    }
    return nombreDeMagasin;
}


Console.WriteLine("Barnabé a fait ses courses dans " +  NombreDeMagasin(s) + " magasin(s).");
