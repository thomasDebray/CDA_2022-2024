// See https://aka.ms/new-console-template for more information
using Exercice_9;
Voiture auto = new Voiture();
Voiture monAuto = new Voiture(new Moteur(), new Roue(), new Roue(), new Roue(), new Roue());
Voiture copieMonAuto = new Voiture(monAuto);
Console.WriteLine(auto.Demarrer()); //true
Console.WriteLine(auto.Avancer());  //true
Console.WriteLine(auto.Arreter());  //true
Console.WriteLine(auto.Arreter());  //false
Console.WriteLine(auto.Avancer());  //false
Console.WriteLine(auto.Demarrer()); //true
Console.WriteLine(auto.Demarrer()); //false

