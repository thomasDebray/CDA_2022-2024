// See https://aka.ms/new-console-template for more information
using ClassLibraryFigures;
using ConsoleAppFigure;

Console.WriteLine("Hello, World!");

VisiteurDeFigurePourConsole visiteur = new VisiteurDeFigurePourConsole();
Cercle c = new Cercle(25, 10, 10);
c.Accept(visiteur);

Figures f = new Figures(0, 0);
f.Add(c);
f.Add(new Rectangle(10,20,0,0));
f.Accept(visiteur);