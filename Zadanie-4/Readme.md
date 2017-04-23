Dla kazdej z zaznaczonych linii kodu /*liczba*/ w powyzszym programie okresl czy
jest poprawna (wpisz TAK) czy nie (powoduje blad kompilacji - wpisz NIE).

 /*1*/  _____Nie

Ta linijka kodu nie jest poprawna, gdyż nie można stworzyć obiektu klasy abstract. Klasa posiada metody ze słowem kluczowym abstract, które mówi, że klasa dziedzicząca musi mieć klasy, które koniecznie nadpiszą taką metodę. 

 /*2*/  _____Nie

Próbujemy uzyskać dostęp do zmiennej ze słowem kluczowym private, która jest w innej klasie. Jeśli chcielibyśmy uzyskać do takiej zmiennej dostęp do należałoby zmienić dostęp do takiej zmiennej na internal lub public, użyć publicznego akcesora. Są też inne sposoby, ale te dwa są najprostrze. 

 /*3*/  _____Tak

Taką metodę z klasy abstract możemy wywołać , gdyż posiada ciało metody, choć tutaj puste -> {}.   

 /*4*/  _____Tak

Tutaj wywołujemy metodaA z klasy B, która nadpisuje metodę o tej samej nazwie w klasie A, która jest abstract(bez ciała metody).

 /*5*/  _____Tak

Zwyczajne stworzenie obiektu B używając konstruktora z klasy B.

 /*6*/  _____Nie

MetodaC w klasie jest oznaczona jako static, a więc nie trzeba tworzyć obiektu, by wywołać metodę, ale w tym przypadku to nie zadziała gdyż domyślny modyfikator dostępu metody jest private. 

 /*7*/  _____Nie

Tutaj modyfikator metody jest już public, ale z kolei metoda nie jest statyczna.

 /*8*/  _____Tak

Tworzymy obiekt klasy A używając konstruktora klasy B dziedziczącej po A, co jest jak najbardziej dozwolone. Następnie próbujemy uzyskać dostęp do zmiennej x, która w klasie A ma modyfikator dostępu internal, co oznacza, że mamy do tej zmiennej dostęp z każdego miejsca w obrębie namespace.  

 /*9*/  _____Nie

Tworzymy obiekt klasy B używając konstruktora z klasy B z parametrem i to jest jak najbardziej poprawne, ale potem pojawia się problem gdyż nie można uzyskać dostęp do zmiennej, która jest w innej klasie oraz posiada domyślny modyfikator, który jest private. 
Domyślne modyfikatory dostępu są najbardziej restrykcyjne z możliwych. 

/*10*/  _____Tak

Dlaczego ? Przecież próbujemy wowołać metodę, która nie jest statyczna jakby nią była. Wszystko zmienia słowo kluczowe new, które tworzy obiekt, a w tym przypadku nowy anonimowy obiekt. Coś podobnego było wykonynawe podczas ćwiczeń w przypadku throw new Esception().

