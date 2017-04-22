Niestety nie pamiętam czy na wykładach były delegacje, ale postaram się wyjaśnić zadanie. 

Słowo kluczowe delegate wskazuje na metodę, która zwraca to samo(lub nie zwraca nic jak w przypadku void) oraz identyczne parametry lub ich brak jak pewna metoda, którą chcemy użyć posługując się delegatem. 

Delegat jest typem referencyjnym, który w przeciwieństwie do wskazywania na obiekt wskazuje na metodę, która charakteryzuje się taki samymi typami i ilością parametrów oraz rodzajem wzracanej wartości. 

```cs
delegate int Delegacja(int i);
    class A
    {
        public event Delegacja SieDzieje;
        public int i = 1;
        public void DoRoboty(int i)
        {
            if (SieDzieje != null)
                this.i += SieDzieje(i);
            else
                this.i = i;
        }
    }
```



W tym przypadku jednak delegate jest sprzężony razem z eventem.
Jeśli odpalimy metodę DoRoboty, a event SieDzieje ma przypisaną wartość null(nie został uruchomiony) to metoda przypisuje do zmiennej i podaną jako parametr metody wartość. 

```cs
A a = new A();
a.DoRoboty(7);
Console.WriteLine("{0}", a.i); 
```
Tak jak tutaj wypisuje, że zmienna i ma wartość równą 7. Odpalił się ten fragment kodu:
```cs
else
    this.i = i;
```

Kolejne linijki kodu sprawiają, że event SieDzieje nie jest już nieaktywny.
```cs
a.SieDzieje += x => 2 * x - 1;
a.DoRoboty(5);
Console.WriteLine("{0}", a.i);
```

Powodują uruchomienie się tego fragmentu kodu:
```cs
if (SieDzieje != null)
     this.i += SieDzieje(i);
```

Powodując zwiększenie zmiennej i(wynoszącej 7) o wartość wedle podanego wzoru zawartego w wyrażeniu lambda:
```cs
x => 2 * x - 1;
```
Dla podanego x, podwój go, a potem odejmij 1.
Sprawia to, że do 7 dodajemy parametr następnego wywołania metody, który wynosi 5 zmieniony wedle wzory parametr*2 -1.
Działanie 7+5*2-1 sprawia, że teraz zmienna i wynosi 16. 
Teraz za każdym wywołaniem metody DoRoboty działoby się wszystko w analogiczny sposób. Do aktualnej wartości zmiennej i dodawano by wynik działania wartość parametru metody *2 -1. 

Jednak kolejna linijka kodu zmienia sposób oblicznia dodawanej wartości
```cs
a.SieDzieje += x => 2 * x + 1;
```
Teraz parametr mnożymy razy 2, a potem odejmujemy. 

Dlatego też wartośc zmiennej i wyniesie 23.

Oczywiście można modyfikować wyrażeniem lambda wedle woli, ale pamiętając, że po pierwszym odpaleniu event będzie się za każdym razem uruchamiał i dodawał wartości do zmiennej i.
Zgodnie z poniższym kodem:
```cs
public void DoRoboty(int i)
        {
            if (SieDzieje != null)
                this.i += SieDzieje(i);
           ...
```
 





