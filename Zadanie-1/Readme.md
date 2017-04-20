Postaram się w miarę przystępnie wyjaśnić co i jak przebiega. Przyjęta przeze mnie konwencja wygląda następująco. 
Pierwsza linijka kodu oraz pierwsza linijka drukująca wynik. W poniższym przykładzie 1 i 4 linijka. 

```cs
K2 x = new K2 { X = 3, K = new K1 { A = 5 } };

Console.WriteLine("x.K.A = {0}, x.X = {1}", x.K.A, x.X);
```

Najpierw tworzy się obiekt K2 przy użyciu domyślnego konstruktora(bez parametrów).
Oto ten konstruktor, który tworzy obiekt o nazwie x.
```cs
public K2()
        {
            X = -1;
            K = new K1();
            K.A = -7;
        }
```
Konstruktor ten oprócz stworzenia obiektu x przypisuje wartości do zmiennych. 
Do X = -1;
Następnie tworzy nowy obiekt K, którego konstruktor nie ma, ale c # tworzy go za nas i wygląda tak
```cs 
public K1(){};
```
Ten konstruktor tworzy jedynie obiekt i nic poza tym, ale przypisuje wartości początkowe, które są zapisane w klasie K1.

```cs
class K1
    {
        public int A = 13;
    }
```

Ten konstruktor oprócz stworzenia obiektu przypisuje wartość 13 do zmiennej A.
Jednak trzecia linijka konstruktora K2 do zmiennej A przypisuje wartość -7.
Po stworzeniu konstruktora mamy obiekt x, który ma takie wartości zmiennych.
X = -1 oraz A = -7. 

Jednak zaraz po konstruktorze jest pole inicjalizujące, które zmienia wartości zmiennych. 
Dla X = 3, a dla drugiej A =5 (Najpierw do zmiennej A przypisuje wartość domyślną, która jest w klasie K1, która wynosi 13, a potem pole inicjalizujące zmienia tą wartośc na wartośc 5.
Przez to na koniec x.X = 3, a x.K.A = 5.


Kolejne linijki kodu 2 i 5.
```cs
K1 k1 = new K1() { A = 3 };
Console.WriteLine("k1.A  = {0}", k1.A);
```
Mniej skomplikowany przykład, który niejako zawiera się w poprzednim. 
Tutaj tworzymy obiekt o nazwie k1 klasy K1 przy użyciu konstruktora domyślnego(bez parametrów) z klasy K1, która wygląda tak: 

```cs
class K1
    {
        public int A = 13;
    }
```
Po stworzeniu obiektu wartość zmiennej A wynosi 13 i tak by zostało gdyby nie 
```cs
{A = 3 }
```
zaraz po konstruktorze, a przed średnikiem.
Przez ten element kodu następuje zmienienie wartości zmiennej A z 13 na 3. 
Na koniec wartość zmiennej k1.A wynosi 3.


Ostatnie linijki kodu z tego przykładu.

```cs
K2 y = new K2(14, new K1()) { X = -1 };
Console.WriteLine("y.K.A = {0}, y.X = {1}", y.K.A, y.X);
```

Tutaj tworzymy obiekt y klasy K2 używając konstruktora z dwoma parametrami. 
Oto ten konstruktor:
```cs
public K2(int x, K1 k)
        {
            X = x;
            K = k;
        }
```
Pierwszy parametr to int x, a drugi obiekt klasy K1.
Najpierw do wartości X przypisujemy wartość 14, a w przypadku drugiego parametru odpalamy konstruktor domyślny K1, który wygląda tak:
```cs
public K1(){}
```
Tworzy się obiekt anonimowy klasy K1, który przyjmuje wartości początkowe zmiennych, które to zostały podane w klasie K1.
Do zmiennej A przypisuje wartość 13.
Na chwilę obecną wartość A =13, a X = 14, ale zostało jeszcze pole zaraz za konstruktorem. 
```cs
{ X = -1 };
```
Tutaj następuje zmiana wartości zmiennej X na wartość -1.
Na koniec wartość X wynosi -1, a A wynosi 13. 


Na koniec jeszcze dopowiem odnośnie nazw zmiennych. 
Dostęp do nich mamy poprzez podanie nazwy obiektu, a po kropce nazwy zmiennej.
Obiekt klasy K2 nie ma dostępu do zmiennej A bezpośrednio, ale może zobaczyć co w niej jest i ją zmodyfikować poprzez podanie po kropce nazwy obiektu klasy K1 oraz nazwy zmiennej w tej klasie, a to dzięki temu, że obiekt klasy K2 ma obiekty klasy k1 jako swoje zmienne. 















 




