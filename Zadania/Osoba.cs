using System;

namespace Zadania
{
    public class Osoba
    {
        private string imie;
        private string nazwisko = "Kowalski";
        private int numerEwidencyjny;
        private Adres adresZamieszkania;


        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Osoba(string imie, string nazwisko, int numerEwidencyjny, Adres adresZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerEwidencyjny = numerEwidencyjny;
            this.adresZamieszkania = adresZamieszkania;
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba()
        {
        }

        public override string ToString()
        {
            return "Imie: " + imie + "\n Nazwisko: " + nazwisko;
        }
    }
}