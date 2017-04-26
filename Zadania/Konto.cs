using System;


namespace Zadania
{
    public class Konto
    {
        private Osoba właściciel;
        private decimal saldo = 0;
        private int pin = 0;

        public void zmieńPin(int oldPin, int newPin)
        {
            if (oldPin == pin)
            {
                this.pin = newPin;
            }
        }

        public void wypłać(int pin, decimal kwota)
        {
            if (pin == this.pin)
            {
                if (saldo - kwota >= 0)
                {
                    this.saldo -= kwota;
                }
                else
                {
                    Console.WriteLine("Nie można wypłacić tej kwoty");
                }
            }
        }

        public void podajInfo(int pin)
        {
            if (pin == this.pin)
            {
                Console.WriteLine("Konto: {0} {1}",właściciel.Imie, właściciel.Nazwisko);
                Console.WriteLine("Saldo: {0}", saldo);
                Console.WriteLine("Pin: {0}",this.pin);
            }
            else
            {
                throw new Exception("Nieprawidłowy pin");
               // Console.WriteLine("Nieprawidłowy pin");
            }

        }

        public Konto(Osoba właściciel, decimal saldo, int pin)
        {
            this.właściciel = właściciel;
            this.saldo = saldo;
            this.pin = pin;
        }
    }
}