```cs
static void Main(string[] args)
        {
            C x = new C(3);
            Console.ReadLine(); 
        }
```

Tworzymy obiekt klasy C, który jest najniżej w hierarchi dziedziczenia. Uruchamiamy konstruktor z parametrem, który wygląda tak:
```cs
C(int i) : base(2 * i)
        {
            Console.WriteLine("C: {0}", i + 2);
        }
```

Jednak nie wypisuje program nic na ekranie tylko tworzy konstruktor po którym C dziedziczy, a więc B() i tak do klasy bazowej, która nie dziedziczy po żadnej stworzonej przez nas klasie. 
Kod poniższy oznacza:
```cs 
base(2 *i)
```
Iż wywołujemy konstruktor nadklasy i jako parametr wrzucamy podwojoną wartość jaką mieliśmy na początku. 
```cs
B(2*i)
```
Konstruktor  z parametrem klasy B wygląda tak:
```cs
public B(int i) : base(2 * (i + 1))
        {
            Console.WriteLine("B: {0}", i);
        }
```

Też nic nie wypisujemy i wywołujemy konstruktor nadklasy, klasy A.
Jako parametr dajemy 2*(i +1).
```cs
A(2*(i+1)) 
```
Pamiętać jednak należy, że i nie wynosi tutaj 3, a tyle ile wynosiło gdy umieszczaliśmy je w konstruktorze B i wynosiło 6.
```cs
protected A(int i)
        {
            Console.WriteLine("A: {0}", i);
        }
```
wywołujemy konstruktor A(14) i dopiero teraz pojawia się pierwszy napis w programie.
A: 14

Schodzimy do konstruktora B z parametrem, który po wywołaniu wyglądał B(6). 
Po wywołaniu ciała konstruktora i wypisaniu B: 6.

Po tym schodzimy jeszcze niżej i tutaj dopiero wypisuje to co konstruktor C, od którego zaczęliśmy na początku.
A jest to C: 5.

Konstruktor który wywołujemy jest niejako uruchamiany ostatni. Należy uważać na wartości parametrów, które przekazuje się, gdyż tutaj najłatwiej się nadziać i zrobić błąd. 
W tym przykładzie najłatwiej byłoby wypisywać od dołu wartości. Te z konstruktora klasy C jako ostatnia wartość, to co wypisze konstruktor B nad tą wartośćią itp.   









