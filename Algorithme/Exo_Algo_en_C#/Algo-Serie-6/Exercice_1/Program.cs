/*
 * Soit T un tableau de nombres entiers non trié.
 * Le programme trie le tableau et affiche tous ses éléments par ordre croissant.
 * 
 * DECLARATION DE VARIABLE
 * 
 * tableauDeNombre est un tableau d'entier
 * j <-- 0 est un entier
 * k <-- 0 est un entier
 * temp est un entier
 * 
 * TRAITEMENT
 * 
 * FOR (k = 0; k < tableauDeNombre.lenght ; k++)
 *      FOR (i = k; i < tableauDeNombre.lenght ; i++)
 *          SI tableauDeNombre[i]<tableauDeNombre[j]
 *              j <-- i
 *          FINSI
 *      FINFOR
 *      temp <-- tableauDeNombre[k]
 *      tableauDeNombre[k] <-- tableauDeNombre[j]
 *      tableauDeNombre[j] <-- temp
 *      FINFOR
 *      ECRIRE tableauDeNombre[k]
 * FINFOR
 */

int[] tableauDeNombre = { 1,5,3,4 };
int j = 0;
int temp;

for (int k = 0; k < tableauDeNombre.Length; k++)
{
    j = k;
    for (int i = k; i < tableauDeNombre.Length; i++)
    {
        if (tableauDeNombre[i]<tableauDeNombre[j])
        {
            j = i;
        }
    }
    temp = tableauDeNombre[k];
    tableauDeNombre[k] = tableauDeNombre[j];
    tableauDeNombre[j] = temp;
    Console.WriteLine(tableauDeNombre[k]);
}
