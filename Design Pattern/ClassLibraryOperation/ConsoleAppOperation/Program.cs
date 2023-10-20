using ClassLibraryOperation;

Expression exp1 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
double resultat1 = exp1.Evalue();

