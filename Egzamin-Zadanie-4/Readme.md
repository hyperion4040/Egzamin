W tym przykładzie pojawiają sie dwa nowe słowa kluczowe. Operator oraz implicit. 
Operator to znak lub kilka znaków(zwykle nie będące literami), które mają określone znaczenie w języku programowania. 
Dla przykładu operator poniżej:
```cs
 ++
```
oznacza inkrementację(zwiększenie wartości zmiennej o 1). 

Możemy określić zachowanie takiego operatora w przypadku, gdy użyjemy go w tym konkretnym zadaniu z naszymi obiektami.

Dla przykładu w tym zadaniu stworzyliśmy klasę Liczba, która posiada tylko jedną zmienną int o nazwie X.
Bez zastosowania operatorów, chcąc przypisać 2 do zmiennej naszego obiektu należałoby napisać poniższy kod:
```cs
Liczba liczba1 = new Liczba(2);
```

Z użyciem operatora, który pozwala na konwersję zarówno jawną jak i niejawną, możliwe jest przypisanie 2 w poniższy sposób.
```cs
Liczba liczba1 = 2;
```

Umożliwia to poniższy kod:
```cs
public static implicit operator Liczba(int liczba) {
      return new Liczba(liczba);
}
```

Nie jesteśmy jednak ograniczeni do takiej prostej wersji. W zadaniu zastosowano pewną modyfikację. 
```cs
public static implicit operator Liczba(int x) {
      return new Liczba(x -1);
}
```
Do zmiennej w obiekcie klasy Liczba nie zostanie przypisana wartość jaką podaliśmy, ale ta wartość pomniejszona o 1. 
```cs
Liczba liczb2 = 3;
```
Powyższy kod sprawia, że do zmiennej X w obiecie liczba2 nie zostanie przypisana wartość 3, ale 2. 

```cs
Liczba x = 2;
Liczba y = 4;
```

Zmienna x.X posiada przypisaną wartość równą 1, a zmienna y.X ma przypisaną wartość 3. 

Poraz zająć się poniższym kodem:
```cs
public static Liczba operator +(Liczba x, Liczba y) {
      Liczba a = new Liczba(x.X);
      a.X += y.X * 2;
      return a;
}
```

Jak to zmienia sytuację w poniższym kodzie.
```cs
Liczba x = 2;
Liczba y = 4;
Liczba z = x + y;// + 2; wykomentowałem ostatnie dodawanie, gdyż komplikuje przykład. Wróce do do niego nieco później.
```

Wiemy, że do obiektów x i y nie przypisujemy takich samych wartości jakie podajemy, ale ich pomniejszone o 1 wersje. 
Operator + w przypadku obiektów klasy liczba wpierw tworzy obiekt klasy Liczba z parametrem lewej strony dodawania, a w tym przypadku to zmienna x.X. A więc korzystamy ze zwykłego tworzenia obiektu. Nie pomniejszamy go po raz kolejny. 
Następnie do wartości zmiennej X nowego obiektu dodajemy podwojoną wartość zmiennej X z obiektu po prawej stronie dodawania. 
Na koniec zwracamy obiekt. Teraz zarówno obiekt a jak i z posiadają taką samą referencję. 
Na chwilę obecną obiekt z posiada zmienną X, która jest równa 1 + 3*2 = 7. 
Jednak co z dodanie zwykłej wartości 2 w poniższym kodzie:
```cs
Liczba z = x + y + 2;
```
Tutaj należy uważać, gdyż 2 to nie obiekt klasy Liczba, ale zwykły int, który przed dodaniem musi zostać poddany castowaniu jawnemu. Oznacza to, że musi zostać zamieniony na obiekt zgodnie z fragmentem kodu jaki jest poniżej:
```cs
public static implicit operator Liczba(int x) {
      return new Liczba(x -1);
}
```
Dodajemy nie 2, ale obiekt z wartością zmiennej X równą 1.
Po dodaniu takiego obiektu wedle operatora + dopiero teraz do zmiennej X w obiekcie z dodajemy 1*2.
Zmienna X obiektu z powstała w wyniku takich operacji 1 +3*2 + 1*2=9.

Fragment kodu wypisze trzy liczby: 1 3 9.














         



