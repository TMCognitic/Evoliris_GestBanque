using Models;

namespace Evoliris_GestBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne titulaire = new Personne() { Nom = "Norris", Prenom = "Chuck", DateNaiss = new DateTime(1953, 3, 10) };

            Courant courant = new Courant() { Numero = "001", LigneDeCredit = 500, Titulaire = titulaire };

            Console.Write("Dépot de -100 : ");
            courant.Depot(-100);
            Console.WriteLine(courant.Solde);


            Console.Write("Dépot de 100 : ");
            courant.Depot(100);
            Console.WriteLine(courant.Solde);

            Console.Write("Retrait de 200 : ");
            courant.Retrait(200);
            Console.WriteLine(courant.Solde);

            Console.Write("Retrait de 500 : ");
            courant.Retrait(500);
            Console.WriteLine(courant.Solde);
        }
    }
}
