// See https://aka.ms/new-console-template for more information
using ClassLibraryEmprunt;
Console.WriteLine("Hello, World!");
Emprunt monEmprunt;
monEmprunt = new Emprunt();
bool result = monEmprunt.PeriodiciteRemboursement.ElementAt(0).Value;
if (result)
{
    Console.WriteLine("OUi");
}
monEmprunt.CalculerNombreRemboursement();
Console.WriteLine(monEmprunt.NombreRemboursement);
monEmprunt.CapitalEmprunte = 10000;
monEmprunt.CalculerMontantRemboursement();
Console.WriteLine(monEmprunt.MontantRemboursement);
