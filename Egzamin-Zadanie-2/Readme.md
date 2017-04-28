Serializacja/deserializacja jest sposobem zamieniania obiektu jaki został utworzony podczas działaniania programu i zamienienie go na strumień, który potem można zapisać jako plik .dat w poniższym zadaniu. 

```cs
[Serializable()]
    public class MojaKlasa
```

Poprzez taki zapis nad klasą informujemy, że ta klasa, a dokładniej obiekt jaki zostanie utworzony za pomocą konstruktora tej klasy będzie podlegać procesowi serializacji(konwersji).

W tej klasie są 4 metody oznaczone jako:

```cs
 [OnSerializing()]
```
Metoda jest odpalana podczas serializacji. 

```cs
  [OnSerialized()]
```
Metoda jest odpalana jak serializacja zostanie zakończona.

```cs
 [OnDeserializing()]
```
Metoda jest odpalana podczas deserializacji.

```cs
[OnDeserialized()]
```
Metoda jest odpalana na zakończenie deserializacji.

Każda z tych metod modyfikuje zmienną A, która została zadeklarowana i zainicjowana wartością 7 w klasie oraz wypisaniem jej wartości.

Na początku wartość zmiennej A wynosi 7. 
Rozpoczyna się serializacja
```cs
try {
     fs = new FileStream("dane.dat", FileMode.Create);
     formater.Serialize(fs, obj);
}
```

co oznacza, że odpalana jest ta metoda:

```cs
[OnSerializing()]
internal void OnSerializingMethod(StreamingContext context) {
     A += 1;
     Console.WriteLine("{0}", A);
}
```
Zwiększana jest wartość zmiennej A o 1 i wypisana jej wartość. 
Ta wartość jest zapisywana do strumienia oraz potem do pliku data.dat

Gdy serializacja zostaje zakończona odpalana jest poniższa metoda:

```cs
[OnSerialized()]
internal void OnSerializedMethod(StreamingContext context) {
      A += 2;
      Console.WriteLine("{0}", A);
}
Wówczas zostaje zwiększona wartość zmiennej A o 2 i zostaje wypisana. 

Gdy zaczyna się uruchamiać poniższy fragment kodu:

```cs
try {
     fs = new FileStream("dane.dat", FileMode.Open);
    obj = (MojaKlasa)formater.Deserialize(fs);
}
```

Zostaje plik dane.dat zamieniony na strumień i wyciągane to informacje jakie zawierał obiekt, który został utworzony i potem zserializowany.
Zmienna A w tym obiekcie wynosi 8.

Gdy rozpoczyna się proces deserializacji jest uruchamiana poniższa metoda:
```cs
[OnDeserializing()]
internal void OnDeserializingMethod(StreamingContext context) {
	A -= 2;
	Console.WriteLine("{0}", A);
}
```

Metoda zmniejsza wartość zmiennej A o 2 i wypisuje tą wartość zmiennej. 
Dlaczego jednak wypisuje -2 ? Metoda jest odpalana podczas deserializacji, ale gdy nie jest jeszcze ukończona. Maszyna nie wie, że zmienna A w strumieniu wynosi 8, nie patrzy też na wartość początkową zmiennej A, ale przyjmuje, że zmienna A posiada wartość domyślną, a więc 0. 
Gdy odejmuje 2 od 0 wypisuje wartość -2.

Gdy serializacja jest zakończona i program wie ile w pliku, a potem w strumieniu wynosiła wartość zmiennej A =8. Zmniejsza ją wedle poniższego kodu w ciele metody:
```cs
[OnDeserialized()]
internal void OnDeserializedMethod(StreamingContext context) {
      A -= 1;
      Console.WriteLine("{0}", A);
}
```

Wypisuje zatem wartość zmiennej A równą 7. 

Jeszcze jest jeden fragment kodu na samym końcu, który wypisuje też wartość zmiennej A po całym procesie serializacji i deserializacji. 
Wypisuje w tym wypadku po raz kolejny wartość 7.













