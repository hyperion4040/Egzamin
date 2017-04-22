Przykład podobny do zadania z delegacjami w pliku z kolokwium. 
```cs
delegate int Delegacja(int i);
    class A{
        public event Delegacja SieDzieje;
        public int i = 2;
        public void DoRoboty(int i)
        {
            if (SieDzieje != null)
                this.i += SieDzieje(i);
            else this.i = i;
        }
    }
```
Powyższy fragment kodu jest niemal identyczny z wyjątkiem wartości zmiennej i, która teraz jako początkową wartośc ma 2.

```cs
A a = new A();
a.DoRoboty(2);
Console.WriteLine("{0}", a.i);
```
Sytuacja analogiczna do wspomnianego przykładu. 
event nie został wywołany i wówczas warunek 
```cs
if (SieDzieje != null)
       this.i += SieDzieje(i);
else this.i = i;
```
I wykonuje się fragment kodu po else, który przypisuje parametr zmiennej i. 
Na koniec tego zmienna i jest równa 2.

```cs
Delegacja raz = x => { Console.WriteLine("jeden"); return x - 1; };
a.SieDzieje +=  new Delegacja(raz);
```
Powyższe dwie linijki warto analizować razem. 
W przykładzie z kolokwium nie było deklarowania Delegacji i potem przypisania. 
Powyższy fragment kodu można traktować jako:
```cs
A cs;
cs = new A();
```
A w tamtym zadaniu było, ale i tutaj jako:
```cs
A cs = new A();
```

Te dwie linijki kodu z delegacją moglibyśmy zapisać w ten sposób:
```cs
a.SieDzieje += x=> {Console.WriteLine("jeden"); return x-1;};
```

Wracając do analizowania kodu:
```cs
a.DoRoboty(a.i);
Console.WriteLine("{0}", a.i);
```
Pierwsza linijka drukuje napis jeden, gdyż w ciele wyrażenia lambda było
```cs
Console.WriteLine("jeden");
```
Oprócz tego dodaje wartość zmiennej i -1 do zmiennej i.
Wynikiem tego zmienna i wynosi po tych operacjach 3.

Kolejny fragment kodu 
```cs
a.SieDzieje += new Delegacja(delegate(int x)
       { Console.WriteLine("dwa {0}", x * a.i); return 1 + x; });
```
Można przyrównać do tworzenia konstuktora z zainicjowanym polem kostruktora tuż za nim.
Nadpisuje to zasady, które obowiązywały dotychczas na zawarte w powyższym kodzie. 
Wypisz napis dwa a zaraz po nim wartość parametru pomnożona przez wartość zmiennej. 
Wynik jaki uzyskamy po wywołaniu 
```cs
a.DoRoboty(a.i);
```
Jest oczywiście: dwa 9
A poniżej zostaje do zmiennej i dodana wartość liczbowa parametru metody DoRoboty() +1.
Wynikiem tego wartość zmiennej została zmieniona na 7.

```cs
 a.SieDzieje += new Delegacja(raz);
 a.DoRoboty(a.i);
 Console.WriteLine("{0}", a.i);
```
Pierwsza linijka sprawia, że wracamy do zasad ustalonych zaraz w tym fragmencie kodu:
```cs
Delegacja raz = x => { Console.WriteLine("jeden"); return x - 1; };
```
Po wywołaniu metody DoRoboty z parametrem na obiekcie a zostaje wypisany wpierw napis jeden, a potem do wartości zmiennej zostaje dodane wartość parametru jaki daliśmy w metodzie DoRoboty -1.
Ostatecznie po wypisaniu wartości zmiennej wiadomo, że zmienna i wynosi 13.

Powód dla którego po tym jak event został uaktywniony cały czas dodajemy liczby do zmiennej i widać w tym fragmencie kodu:

```cs
this.i += SieDzieje(i);
```


 











