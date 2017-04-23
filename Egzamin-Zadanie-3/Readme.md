Pierwsza linijka jest dość prosta
```cs
Console.WriteLine("A: {0} {1} {2}", new A().g(), new A().h(), new A().i());
```
 i wszystko rozgrywa się w poniższej klasie:
```cs
public class A {
        public static int a = 7;
        public virtual int g() { a++; return h(); }
        public virtual int h() { a--; return i(); }
        public int i() { return a; }
    }
```
Należy jednak uważać na zmienną a, która jest zmienną statyczną. 

Poniższy fragment kodu znajdujący się wewnątrz pierwszej linijki w w metodzie Main
```cs
new A().g()
```
Wywołuje metodę:
```cs
public virtual int g() { a++; return h(); }
```
Metoda ta zwiększa o 1 wartość zmiennej statycznej a i po tej operacji wynosi 8. Następnie wywołuje poniższą metodę:
```cs
public virtual int h() { a--; return i(); }
```
która to zmniejsza wartość zmiennej a o 1 i po tej operacji wynosi ponownie 7. Następnie wywołuje metodę i(), która
zwraca wartość zmiennej statycznej a, która wynosi 7.

Kolejna wartość w omawianej linijce w metodzie Main
```cs
new A().h()
```
wywołuje metodę h(), która wygląda następująco:
```cs
public virtual int h() { a--; return i(); }
```
Metoda ta zwiększa o 1 wartość zmiennej a, ale ta zmienna ze względu, że jest statyczna posiada wartość jaka pozostała po poprzednich oeracjach jakie zostały z jej udziałem wykonane. Zdarzyło się, że nadal wynosi 7, ale nie zawsze musi tak być.

Wracając do linijki kodu zmniejszamy wartość zmiennej statycznej o 1 i wywołujemy metodę i(), która zwraca wartość zmiennej statycznej a, która to wynosi 6.

```cs
new A().i()
```
Powyższy fragment kodu wywołuje metodę i(), która to zwraca wartość zmiennej a, ale ta zmienna z racji, że jest statyczna wynosi 6, a nie 7 pomimo, że stworzono nowy obiekt. 

Zmienna a wynosi 6.

Kolejna linijka kodu jaki jest wykonywany w metodzie Main:
```cs
Console.WriteLine("B: {0} {1} {2}", new B().g(), new B().h(), new B().i());
```

Pierwszy element 
```cs
new B().g()
```

Tworzymy anonimowy obiekt klasy B, która jest klasą potomną klasy A. 
Wpierw wywołujemy metodę g() na obiekcie anonimowym. Klasa B wygląda następująco:
```cs
class B : A {
        public int b = 12;
        public override int h() { b++;  return (a++) + (--b); }
        public new int i() { return this.g(); }
        static void Main(string[] args) {
            Console.WriteLine("A: {0} {1} {2}", new A().g(), new A().h(), new A().i());
            Console.WriteLine("B: {0} {1} {2}", new B().g(), new B().h(), new B().i());
            //Console.ReadLine();
        }
    }
```
Nie ma tutaj metody g(), a więc sytuacja prosta, pozostaje klasa A, gdzie metoda ta jest oznaczona słowem kluczowym virtual, co oznacza, że klasa, która po niej dziedziczy może ją nadpisać, ale nie musi. 

```cs
public virtual int g() { a++; return h(); }
```

Pamiętamy, że zmienna statyczna a wynosi 6. Ta metoda zwiększa wartość tej zmiennej o 1 i wynosi 7. Wywołujemy metodę h().
Klasa A posiada taką metodę, również oznaczoną jako virtual, ale w klasie B metoda h() jest oznaczona jako override, co oznacza, że właśnie z tej wersji metody h() skorzystamy. 
```cs
public int b = 12;
public override int h() { b++;  return (a++) + (--b); }
```

Zwiększamy o 1 wartość zmiennej b, która teraz wynosi 13. 
Teraz uwaga, gdyż pojawiła się pułapka. inkrementacja poprzez ++x oraz x++ nie są sobie tożsame w przypadku jak jednocześnie zwracamy wartość poprzez return lub przypisując do jakiejś zmiennej. 

```cs
x++ // Zwraca wartość zmiennej zanim zwiększy wartość zmiennej o 1
```

```cs
++x //Zwraca wartość zmiennej po tym jak zwiększy wartość zmiennej o1
```

Z  x-- oraz --x jest analogicznie. 

Co to oznacza w praktyce ? 
```cs 
return (a++) + (--b);
```
Zwracamy wartość, w której dokonano tylko jednej zmiany wartości, a nie dwóch. 
Zmienna b została zmniejszona przez zwróceniem, ale zmienna a nie została zwiększona. 
Oznacza to, że zwrócono wartość 19, a nie 20. Przy zwracaniu wartość zmiennej a wynosiła 7, a zmiennej b 12. Po zwróceniu wartość zmiennej a wynosi już 8, a wartość zmiennej b 12. 
Pamiętamy, że zmienna a jest zmienną statyczną i jej wartość zostaje taka jak po ostatnich operacjach. 

Kolejny fragment kodu wygląda następująco:
```cs
new B().h()
```
Zostaje wywołana metoda h() z klasy B, która wygląda następująco:
```cs
public override int h() { b++;  return (a++) + (--b); }
```
Zwiększamy wartość zmiennej b o 1 i wynosi aktualnie 13. Następnie zwracamy jeszcze nie zwiększoną wartość zmiennej a, która wynosi 8 oraz zmniejszoną wartość zmiennej b, która teraz wynosi 12. Zwrócona wartość wynosi 20, ale dopiero teraz zmienna a jest zwiększana o 1 i wynosi 9. 

Ostatni fragment kodu:
```cs
new B().i()
```

wywołuje metodę i()
```cs
public new int i() { return this.g(); }
```
która wywołuje metodę g() z klasy A. Metoda ta wygląda następująco:
```cs
 public virtual int g() { a++; return h(); }
```
Wartość zmiennej statycznej wynoszącej 9 zostaje zwiększona o 1 i wynosi 10. Wywołujemy metodę h(), która znajduje się w klasie B:
```cs
public override int h() { b++;  return (a++) + (--b); }
```
Zmienna b wynosi 12, a po zwiększeniu o 1 po wywołaniu poniższego fragmentu kodu:
```cs
b++;
```
Teraz zmienna b wynosi 13. Następny fragment kodu zmniejsza wartość zmiennej b o 1 i wynosi 12, ale nadal nie dotykamy zmiennej a, która zmieni wartość dopiero po zwróceniu wartości, ale tego już nam nie wydrukuje. Jak do tej pory zmienna a wynosiła 10. Zwrócona wartość wynosi 22.
 














 



