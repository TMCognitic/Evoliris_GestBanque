namespace Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

        public required string Nom { get; set; }

        public Courant this[string numero]
        {
            get { return _comptes[numero]; }
        }

        public void Ajouter(Courant courant)
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

            foreach (Courant compte in _comptes.Values.Where(c => c.Titulaire == titulaire))
            {
                total += compte;
            }

            return total;
        }
    }
}
