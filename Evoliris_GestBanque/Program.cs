namespace Evoliris_GestBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque banque = new Banque() { Nom = "EvolirisBanking" };
            Personne titulaire = new Personne() { Nom = "Norris", Prenom = "Chuck", DateNaiss = new DateTime(1953, 3, 10) };

            Courant courant = new Courant() { Numero = "001", LigneDeCredit = 500, Titulaire = titulaire };
            banque.Ajouter(courant);

            Epargne epargne = new Epargne() { Numero = "002", Titulaire = titulaire };


            Console.Write("Dépot de -100 sur courant : ");
            banque["001"].Depot(-100);
            Console.WriteLine(banque["001"].Solde);


            Console.Write("Dépot de 100 sur courant : ");
            banque["001"].Depot(100);
            Console.WriteLine(banque["001"].Solde);

            Console.Write("Retrait de 200 sur courant : ");
            banque["001"].Retrait(200);
            Console.WriteLine(banque["001"].Solde);

            Console.Write("Retrait de 500 sur courant : ");
            banque["001"].Retrait(500);
            Console.WriteLine(banque["001"].Solde);

            Console.Write("Dépot de 100 sur epargne : ");
            epargne.Depot(100);
            Console.WriteLine(epargne.Solde);

            Console.Write("Retrait de 200 sur epargne : ");
            epargne.Retrait(200);
            Console.WriteLine(epargne.Solde);

            Console.Write("Retrait de 50 sur epargne : ");
            epargne.Retrait(50);
            Console.WriteLine($"{epargne.Solde} en date du {epargne.DateDernierRetrait:yyyy-MM-dd}");
        }
    }
}
