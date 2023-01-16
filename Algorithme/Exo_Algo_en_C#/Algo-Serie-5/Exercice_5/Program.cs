/*
 * L'utilisateur est invité à entrer un texte d'au moins 120 caractères
 * Le programme compte et affiche le nombre d'occurrence de chacune des lettres de l'alphabet.
 * 
 * DECLARATION DE VARIABLE
 * 
 * input est une chaîne
 * alphabet est un tableau = {a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z}
 * occurence est un entier
 * 
 * TRAITEMENT ET RESULTAT
 * 
 * FAIRE
 *      ECRIRE "Veuillez entrer un texte d'au moins 120 caractères"
 *      LIRE input
 *      SI input.lenght >= 120 ALORS
 *          FOR (i = 0; i < alphabet.lenght ; i ++)
 *              FOR (j = 0 ; j< input.lenght ; j ++)
 *                  SI input[j]==alphabet[i]
 *                      occurence++
 *                  FINSI
 *              ECRIRE alphabet[i], " apparait ", occurence, " fois."
 *              FINFOR
 *          occurence <-- 0
 *          FINFOR
 *      FINSI
 * TANT QUE input.lenght < 120
 */

string input;
char[] alphabet = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','x','y','z' };
//string alphabet = "abcdefghijklmnopqrstuvwxyz" ;
int occurence=0;

do
{
    Console.WriteLine("Veuillez entrer un texte d'au moins 120 caractères");
    input = Console.ReadLine();
    if (input.Length >= 120)
    {
        for (int i = 0; i < alphabet.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j].Equals(alphabet[i]))
                {
                    occurence++;
                }  
            }
            Console.WriteLine(alphabet[i] + " apparait " + occurence + " fois.");
            occurence = 0;
        }
    }
} while (input.Length<120);

