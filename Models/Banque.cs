namespace Models
{
    public class Banque
    {
        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();

        public string Nom { get; init; }

        public Compte this[string numero]
        {
            get { return _comptes[numero]; }
        }
        
        public Banque(string nom)
        {
            Nom = nom;
        }

        public void Ajouter(Compte courant)
        {
            _comptes.Add(courant.Numero, courant);
        }

        public void Supprimer(string numero)
        {
            _comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0;

            foreach (Compte compte in _comptes.Values.Where(c => c.Titulaire == titulaire))
            {
                total += compte;
            }

            return total;
        }
    }
}
