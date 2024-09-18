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


            Console.Write("Dépot de -100 : ");
            banque["001"].Depot(-100);
            Console.WriteLine(banque["001"].Solde);


            Console.Write("Dépot de 100 : ");
            banque["001"].Depot(100);
            Console.WriteLine(banque["001"].Solde);

            Console.Write("Retrait de 200 : ");
            banque["001"].Retrait(200);
            Console.WriteLine(banque["001"].Solde);

            Console.Write("Retrait de 500 : ");
            banque["001"].Retrait(500);
            Console.WriteLine(banque["001"].Solde);
        }
    }
}
