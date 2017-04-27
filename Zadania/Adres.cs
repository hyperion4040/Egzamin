namespace Zadania
{
    public class Adres
    {
        private string nazwaUlicy ="Aleje Jerozolimskie";
        private string miejscowość = "Warszawa";
        private int numerDomu;
        private int numerMieszkania;

        public Adres()
        {
        }

        public Adres(string miejscowość, int numerDomu, int numerMieszkania)
        {
            this.miejscowość = miejscowość;
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
        }
    }
}