/*using Exercice_2;

Bouteille bouteilleDeChampagne;
bouteilleDeChampagne = new Bouteille();

Bouteille bouteilleDeSake;
bouteilleDeSake = new Bouteille(false,100,0.72f);

Bouteille bouteilleCopie;
bouteilleCopie = new Bouteille(bouteilleDeSake);


bool aReussiAOuvrir = bouteilleDeChampagne.Ouvrir();
Console.WriteLine(aReussiAOuvrir);

bool aReussiABoireUneGorgee = bouteilleDeChampagne.Vider(5);
Console.WriteLine(aReussiABoireUneGorgee);

bool aReussiARemplir5Pourcent = bouteilleDeChampagne.Remplir(5);
Console.WriteLine(aReussiARemplir5Pourcent);

bool aReussiAToutVider = bouteilleDeChampagne.ViderTout();
Console.WriteLine(aReussiAToutVider);

bool aReussiARemplir5Pourcent2 = bouteilleDeSake.Remplir(5);
Console.WriteLine(aReussiARemplir5Pourcent2);


bool aReussiAToutRemplir = bouteilleDeChampagne.RemplirTout();
Console.WriteLine(aReussiAToutRemplir);

bool aReussiAFermer = bouteilleDeChampagne.Fermer();
Console.WriteLine(aReussiAFermer);*/







using Exercice_2;

Bouteille bouteille = new Bouteille();

bouteille.Ouvrir();

bool rt1 = bouteille.Remplir(10); // false ou reste a 100%
bool rt2 = bouteille.Vider(20); // true
bool rt3 = bouteille.Vider(85); // false ou contenace a 0%
bool rt4 = bouteille.Remplir(-20); // false
bouteille.Remplir(20.0f);
bool rt5 = bouteille.Vider(-20.0f);
Console.ReadKey();