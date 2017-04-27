namespace Zadania
{
    public class Stypendysta : Student
    {
        private decimal kwotaStypendium;

        public decimal KwotaStypendium
        {
            get { return kwotaStypendium; }
            set { kwotaStypendium = value; }
        }

        public Stypendysta(string imie, string nazwisko, int numerEwidencyjny, Adres adresZamieszkania, int numerIndeksu, decimal kwotaStypendium) : base(imie, nazwisko, numerEwidencyjny, adresZamieszkania, numerIndeksu)
        {
            this.kwotaStypendium = kwotaStypendium;
        }

        public Stypendysta(string imie, string nazwisko, int numerIndeksu, decimal kwotaStypendium) : base(imie, nazwisko, numerIndeksu)
        {
            this.kwotaStypendium = kwotaStypendium;
        }

        public Stypendysta(int numerIndeksu, decimal kwotaStypendium) : base(numerIndeksu)
        {
            this.kwotaStypendium = kwotaStypendium;
        }

        public Stypendysta(decimal kwotaStypendium)
        {
            this.kwotaStypendium = kwotaStypendium;
        }
    }
}