
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
            courant.PassageEnNegatifEvent += PassageEnNegatifAction;
        }

        private void PassageEnNegatifAction(Compte compte)
        {
            Console.Write($"(Le compte numéro {compte.Numero} vient de passer en négatif) ");
        }

        public void Supprimer(string numero)
        {
            if (!_comptes.ContainsKey(numero))
                return;

            _comptes[numero].PassageEnNegatifEvent -= PassageEnNegatifAction;
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
