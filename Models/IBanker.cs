namespace Models
{
    public interface IBanker : ICustomer
    {
        double LigneDeCredit { get; set; }
        string Numero { get; }
        Personne Titulaire { get; }

        void AppliquerInteret();
    }
}