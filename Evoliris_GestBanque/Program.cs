using Models.Divers;

namespace Evoliris_GestBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carwash carwash = new Carwash();
            Voiture voiture = new Voiture("1-ABC-123");
            carwash.Traiter(voiture);
            Console.WriteLine();

            Banque banque = new Banque("EvolirisBanking");
            Personne titulaire = new Personne("Norris", "Chuck", new DateTime(1953, 3, 10));

            Courant courant = new Courant("001", 500, titulaire);
            banque.Ajouter(courant);

            Epargne epargne = new Epargne("002", titulaire);
            banque.Ajouter(epargne);

            try
            {
                courant.LigneDeCredit = -100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Dépot de -100 sur courant : ");
                banque["001"].Depot(-100);
                Console.WriteLine(banque["001"].Solde);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Dépot de 100 sur courant : ");
            banque["001"].Depot(100);
            Console.WriteLine(banque["001"].Solde);

            Console.Write("Retrait de 200 sur courant : ");
            banque["001"].Retrait(200);
            Console.WriteLine(banque["001"].Solde);

            try
            {
                Console.Write("Retrait de 500 sur courant : ");
                banque["001"].Retrait(500);
                Console.WriteLine(banque["001"].Solde);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Dépot de 100 sur epargne : ");
            banque["002"].Depot(100);
            Console.WriteLine(banque["002"].Solde);

            try
            {
                Console.Write("Retrait de 200 sur epargne : ");
                banque["002"].Retrait(200);
                Console.WriteLine(banque["002"].Solde);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Retrait de 50 sur epargne : ");
            banque["002"].Retrait(50);
            Console.WriteLine($"{banque["002"].Solde} en date du {(banque["002"] as Epargne)?.DateDernierRetrait:yyyy-MM-dd}");
        }
    }
}
