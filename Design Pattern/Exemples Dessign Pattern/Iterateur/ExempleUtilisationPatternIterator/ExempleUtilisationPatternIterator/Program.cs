using BiblioClassFigure;
using System.ComponentModel;
namespace Exo_Fig1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Collection de Cercles
            Circle c1 = new Circle(5, 30, 30);
            Circle c2 = new Circle(6, 40, 40);
            Circle c3 = new Circle(7, 50, 50);
            Circle c4 = new Circle(8, 60, 60);
            Circle c5 = new Circle(9, 7, 70);

            //c1.Draw();

            //Collection de Rectangles
            Rectangle r1 = new Rectangle(3, 1, 1, 1);
            Rectangle r2 = new Rectangle(4, 2, 5, 5);
            Rectangle r3 = new Rectangle(5, 3, 10, 10);
            Rectangle r4 = new Rectangle(6, 4, 15, 15);
            Rectangle r5 = new Rectangle(7, 5, 20, 20);
            
            //r1.Draw();

            //Collection de figures composées de Cercles ou  de rectangles ou des 2 mélangés
            Figures f1 = new Figures(9, 9);
            Figures f2 = new Figures(10, 10);
            Figures f3 = new Figures(11, 11);
            Figures f4 = new Figures(12, 12);
            Figures f5 = new Figures(13, 13);
            Figures f6 = new Figures(14, 14);
            Figures f7 = new Figures(15, 15);
            Figures f8 = new Figures(16, 16);
            Figures f9 = new Figures(17, 17);

            f1.Add(c1);
            f2.Add(c2);
            f2.Add(c3);
            f3.Add(c4);
            f3.Add(c5);

            // f1.Draw();
            f4.Add(r1);
            f5.Add(r2);
            f5.Add(r3);
            f6.Add(r4);
            f6.Add(r5);

            //f2.Draw();

            f7.Add(f1);
            f7.Add(f4);
            f8.Add(f2);
            f8.Add(f5);
            f9.Add(f3);
            f9.Add(f6);

            //f7.Draw();

            //for (int j = 0; j < f7.Count; j++)
            //{

            //    Console.WriteLine(f8[j].ToString());
            //}

            Console.WriteLine("Resultat avec le MoveNext");

            FigureIterator i = new FigureIterator(f5);
           
            while (i.MoveNext())
            {
                Figure figure = i.Current;
                Console.WriteLine(figure.ToString());
            }

            Console.WriteLine("Resultat avec le foreach");

            foreach (Figure f in f5)
            {
                string s = f.ToString();
                Console.WriteLine(f.ToString());
            }
        }
    }
}
