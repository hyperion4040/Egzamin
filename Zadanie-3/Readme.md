Wykonanie metod z pierwszej linijki ogranicza się do operacji w klasie A. 
```cs
 Console.WriteLine("A: {0} {1} {2}", new A().g(), new A().h(), new A().i());
```

Obiekt klasy A wywołuje metodę g() która wygląda tak:
```cs
public virtual int g() { a+=2; return h(); }
```
Tworząc obiekt jednocześnie przypisujemy wartość domyślną zmiennej a zgodnie z tym fragmentem kodu. 
```cs
 public int a = -2;
```

Metoda g() mówi, że zwiększamy wartość zmiennej a o 2 i wynosi ona a = 0. Następnie wywołujemy metodę h(), która wygląda tak:
```cs
 public virtual int h() { a-=2; return i(); }
```
Tutaj z kolei zmniejszamy wartość zmiennej a o 2 i wynosi ona a =0 i wywołujemy metodę i(), która wygląda tak:
```cs 
public int i() { return a; }
```
Ona nie robi nic innego jak zwraca wartość a, która wynosi -2. 


Druga wartość w linijce 
```cs
 Console.WriteLine("A: {0} {1} {2}", new A().g(), new A().h(), new A().i());
```
mówi, że obiekt klasy A wywołuje metodę h(). Wpierw jednak zostaje do zmiennej a przypisana wartość -2. Po wywołaniu medoty h() 
```cs
 public virtual int h() { a-=2; return i(); }
```
zmniejszamy wartość zmiennej do wartości -4, a następnie wywołujemy metodę i().
```cs 
public int i() { return a; }
```
Metoda ta jedynie wzraca wartość zmiennej a, która wynosi -4.


Ostatnia wartość z tej linijki postaje najprościej, gdyż po utworzeniu obiektu klasy A i przypisaniu -2 do wartości zmiennej a, metoda i() zwraca wartość a, a więc zwraca -2.


Kolejna linijka jest już trudniejsza, gdyż nie ograniczamy się w jednej klasie.
```cs
 Console.WriteLine("B: {0} {1} {2}", new B().g(), new B().h(), new B().i());
```

Wpierw może wytłumaczę słowa kluczowe, które się pojawiają.

virtual oznacza, że metoda może być nadpisana, ale nie musi. 
override oznacza, że metoda podklasy nadpisuje metodę klasy bazowej, która została oznaczona jako virtual.
new przy metodzie oznacza, że metoda podklasy ukrywa metodę bazowej i mówi, użyj mnie. 

Obiekt klasy B wywołuje metodę g(), która jest metodą z klasy A i wygląda następująco:
```cs
public virtual int g() { a+=2; return h(); }
```

Oczywiście zmiennej a przypisuje się wartość - 2 , a ta metoda sprawia, że zwiększamy wartość tej zmiennej o 2 i wywołujemy metodę h(). 
Tutaj należy uważać, gdyż nie używamy metody h() z klasy A oznaczonej jako virtual, ale z klasy B, która jest oznaczona override i wygląda tak:
```cs
public override int h() { a++; b--; return a - b; }
```
Uprzednio jednak pamiętając o poniższym fragmencie kodu:
```cs
static int b = 4;
```
który jest oznaczony jako static, co oznacza, że nie będzie się zerował i przyjmowała wartość początową, gdy stworzymy nowy obiekt klasy B.
Po uruchomieniu metody h() wartość zmiennej a ulega zwiększeniu o 1 i wynosi -1. Wartość zmiennej b zostaje zmniejszona o 1 i wynosi 3. Na końcu zwracamy wynik działania -1 -3 i otrzymujemy -2.

Następny obiekt w tej linijce kodu B().h() wywołuje metodę h() z klasy B, ale wpierw inicjujemy konstruktor nadklasy, który przypisuje zmiennej a wartość -2. Metodę h() używamy z klasy B ze względu na słowo kluczowe override. 
```cs
public override int h() { a++; b--; return a - b; }
```
Zmienna a ulega zwiększeniu o 1 i wynosi -1, a zmienna b po zmniejszeniu o 1 wynosi 2. Dlaczego nie 3 ? Gdyż ta zmienna jest static i już raz ją zmniejszaliśmy dla innego obiektu. 
Metoda zwraca wynik działania -1 - 2 co daje na -3.

Ostatnia wartość, którą daje B().i() jest wynikiem tego, że znowuż zmiennej a przypisujemy wartość -2. 
w klasie B jest metoda i() ze słowem kluczowym new, który oznacza nową instancję i wygląda następująco:
```cs
public new int i() { return this.g(); } 
```
Wywołujemy metodę g() z klasy A, gdyż w klasie B nawet go nie ma i nie musimy się zastanawiać której użyć. 
```cs
public virtual int g() { a+=2; return h(); }
```
Metoda ta zwiększa wartość zmiennej a o 2 i teraz wynosi ona 0.
Wywołujemy medotę h() z klasy B, gdyż jest oznaczona jako override i nadpisuje metodę virtual z klasy A(). 
```cs
 public override int h() { a++; b--; return a - b; }
```
Zwiększamy wartość zmiennej a o 1 i wynosi teraz 1. Następnie zmniejszamy wartość zmiennej b, która wynosi 2(zmienna statyczna) i teraz wynosi 1. Po zwróceniu wyniku a-b, 1-1 otrzymujemy 0 i takim sposobem mamy wszystkie wartości. 















