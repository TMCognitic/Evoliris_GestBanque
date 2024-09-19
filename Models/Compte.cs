namespace Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        public static double operator +(double left, Compte right)
        {
            return ((left < 0) ? 0 : left) + ((right.Solde < 0) ? 0 : right.Solde);
        }

        private string _numero;
        private double _solde;
        private Personne _titulaire;

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public double Solde
        {
            get
            {
                return _solde;
            }

            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            set
            {
                _titulaire = value;
            }
        }

        public virtual double LigneDeCredit
        {
            get
            {
                return 0;
            }

            set
            {
                throw new InvalidOperationException();
            }
        }

        public void Depot(double montant)
        {
            if (montant <= 0)
                return;

            Solde += montant;
        }

        protected abstract double CalculInteret();

        public virtual void Retrait(double montant)
        {
            if (montant <= 0)
                return;

            if (Solde - montant < -LigneDeCredit)
                return;

            Solde -= montant;
        }

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }
    }
}