using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Divers
{
    public class Carwash
    {
        private Action<Voiture> _sequence;
        public Carwash() 
        {
            //_sequence += Preparer;
            //_sequence += Laver;
            //_sequence += Secher;
            //_sequence += Finaliser;

            //_sequence += delegate (Voiture voiture) { Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}"); };
            //_sequence += delegate (Voiture voiture) { Console.WriteLine($"Je lave la voiture : {voiture.Plaque}"); };
            //_sequence += delegate (Voiture voiture) { Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}"); };
            //_sequence += delegate (Voiture voiture) { Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}"); };

            _sequence += voiture => Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}");
            _sequence += voiture => Console.WriteLine($"Je lave la voiture : {voiture.Plaque}");
            _sequence += voiture => Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}");
            _sequence += voiture => Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}");
        }

        private void Preparer(Voiture voiture)
        {
            Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}");
        }

        private void Laver(Voiture voiture)
        {
            Console.WriteLine($"Je lave la voiture : {voiture.Plaque}");
        }

        private void Secher(Voiture voiture)
        {
            Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}");
        }

        private void Finaliser(Voiture voiture)
        {
            Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}");
        }

        public void Traiter(Voiture voiture)
        {
            _sequence.Invoke(voiture);
        }
    }
}
