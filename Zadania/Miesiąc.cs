using System;

namespace Zadania
{
    public class Miesiąc
    {
        string[,] miesiąc = new string[,]
        {
            {"Styczeń", "31"},
            {"Luty", "28"},
            {"Marzec", "31"},
            {"Kwiecień", "30"},
            {"Maj", "31"},
            {"Czerwiec", "30"},
            {"Lipiec", "31"},
            {"Sierpień", "30"},
            {"Wrzesień", "31"},
            {"Pazdziernik", "31"},
            {"Listopad", "30"},
            {"Grudzień", "31"}
        };

        public string this[string miesiąc]
        {

            get
            {
                int mon = miesiąc.IndexOf(miesiąc);
                return "Liczba dni w miesiącu " + this.miesiąc[mon,0] + "  to: " + this.miesiąc[mon, 1];
            }
            set
            {
                int mon = miesiąc.IndexOf(miesiąc);
                this.miesiąc[mon, 1] = value;

            }


        }
    }
}