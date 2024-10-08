﻿namespace Models
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

        protected Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        protected Compte(string numero, Personne titulaire, double solde)
            : this(numero, titulaire)
        {
            Solde = solde;
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            private set
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

            private set
            {
                _titulaire = value;
            }
        }

        public void Depot(double montant)
        {
            if (montant <= 0)
                throw new ArgumentOutOfRangeException(nameof(montant), "le montant doit être supérieur à 0");

            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (montant <= 0)
                throw new ArgumentOutOfRangeException(nameof(montant), "le montant doit être supérieur à 0");

            if (Solde - montant < -ligneDeCredit)
                throw new SoldeInsuffisantException("Solde insuffisant");

            Solde -= montant;
        }

        protected abstract double CalculInteret();
        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }
    }
}