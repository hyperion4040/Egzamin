namespace Zadania
{
    public class Wykladowca : Osoba
    {
        private string tytułNaukowy;

        public string TytułNaukowy
        {
            get { return tytułNaukowy; }
            set { tytułNaukowy = value; }
        }

        public Wykladowca(string imie, string nazwisko, int numerEwidencyjny, Adres adresZamieszkania, string tytułNaukowy) : base(imie, nazwisko, numerEwidencyjny, adresZamieszkania)
        {
            this.tytułNaukowy = tytułNaukowy;
        }

        public Wykladowca(string imie, string nazwisko, string tytułNaukowy) : base(imie, nazwisko)
        {
            this.tytułNaukowy = tytułNaukowy;
        }

        public Wykladowca(string tytułNaukowy)
        {
            this.tytułNaukowy = tytułNaukowy;
        }
    }
}