Podobny do tego przykład już był w przykładowych pytaniach kolokwium.
```cs
static void Main(string[] args) {
       C x = new C(6);
}
```
Rozpoczynamy od tego miejsca tworzymy obiekt x klasy C używając konstruktora C() z parametrem.
Poniżej ten konstruktor:
```cs
C(int i): base(i * 2) {
   Console.WriteLine("C: {0}", i + 2);
}
```

Konstruktor wyświetla napis, ale ten napis z tego konstruktora zostanie wyświetlony na końcu. Wpierw zostaje wywołany konstruktor klasy nadrzędnej również z parametrem, ale ten parametr to wartość parametru jaką daliśmy przy tworzeniu obiektu, ale podwojona. Warto zapamiętać parametr jaki miał dany konstruktor w danej klasie lub wypisywać wszystko niejako od końca. 

Klasa B ma dwa konstruktory, ale kod 
```cs
C(int i): base(i *2)
...
```
Mówi, by użyć konstruktora z parametrem. Gdyby ten fragment wyglądał base() to wówczas wskazywałoby, by użyć konstruktora bez parametrów. 

Konstuktor z parametrem klasy B wygląda następująco:
```cs
public B(int i)
      : base(2 + i) {
      Console.WriteLine("B: {0}", i);
}
```
Przyjmuje on wartość jaką nadana została we fragmencie base(2*i), gdzie i było parametrem w 
```cs
C x = new C(6);
```
Zatem wywołujemy konstruktor klasy B z parametrem 12. Nim jednak coś zostanie wypisane z tego konstruktora to należy ponownie wywołać konstruktor klasy nadrzędnej z parametrem zwięszkonym o 2:
```cs
protected A(int i) {
    Console.WriteLine("A: {0}", i);
}
Co jednak ze słowem kluczowym protected. Protected oznacza, że dany konstruktor, metoda jest dostępna w swojej klasie (klasie A) oraz wszystkich dziedziczących po niej. Zatem nic nie zmienia to w sytuacji. Co gdyby zamiast protected było private ? 
Kompilator by się zaczął czepiać, że konstruktor z klasy B nie może wywołać konstruktora z klasy A. 
Dopiero teraz zaczyna się wypisywanie przy pomocy Console.WriteLine();

Parametr jaki otrzymał konstruktor A wynosił 14, a więc wpierw zostanie wydrukowane A: 14. 
Schodzimy niżej. Parametr jaki otrzymał konstruktor B wynosił 12. 
Zostanie następnie wypisane B: 12
I na koniec konstruktor z klasy C, który wypisuje C: 8. Drobna pułapka bo w pozostałych konstruktorach drukował parametr, a tutaj wartość parametru zwiększoną o 2.

W takim przykładzie należy uważać i pamiętać z jakim parametrem konstruktor klasy nadrzędnej został uruchomiony. Można też zacząć niejako od dołu. Wpierw wypisać co wypisze konstruktor C, nad tym napisem co wypisze konstruktor B itd. 








