namespace Zadania
{
    public class Student : Osoba
    {
        private int numerIndeksu;


        public int NumerIndeksu
        {
            get { return numerIndeksu; }
            set { numerIndeksu = value; }
        }

        public Student(string imie, string nazwisko, int numerEwidencyjny, Adres adresZamieszkania, int numerIndeksu) : base(imie, nazwisko, numerEwidencyjny, adresZamieszkania)
        {
            this.numerIndeksu = numerIndeksu;
        }

        public Student(string imie, string nazwisko, int numerIndeksu) : base(imie, nazwisko)
        {
            this.numerIndeksu = numerIndeksu;
        }

        public Student(int numerIndeksu)
        {
            this.numerIndeksu = numerIndeksu;
        }
        public Student(){}
    }
}