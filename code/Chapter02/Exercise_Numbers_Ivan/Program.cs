string rowSeparator = new('-', count: 104);

WriteLine(rowSeparator);
WriteLine($"{"Type",-8} {"Byte(s) of memory",-20} {"Min",30} {"Max",43}");
WriteLine(rowSeparator);

WriteLine($"{"sbyte",-8} {sizeof(sbyte),-20} {sbyte.MinValue,30} {sbyte.MaxValue,43}");
WriteLine($"{"byte",-8} {sizeof(byte),-20} {byte.MinValue,30} {byte.MaxValue,43}");
WriteLine($"{"short",-8} {sizeof(short),-20} {short.MinValue,30} {short.MaxValue,43}");
WriteLine($"{"ushort",-8} {sizeof(ushort),-20} {ushort.MinValue,30} {ushort.MaxValue,43}");
WriteLine($"{"int",-8} {sizeof(int),-20} {int.MinValue,30} {int.MaxValue,43}");

/*
1. What statement can you type in a C# file to discover the compiler and language version?
    - #error version  -> erzeugt absichtlich Compilerfehler

2. What are the two types of comments in C#?
    - // /**/
/*
3. What is the difference between a verbatim string and an interpolated string?
    - Verbatim String (@): Sonderzeichen wie \ werden normalerweise als normale Zeichen behandelt.
        - string pfad = @"C:\Users\Ivan";
    - Interpolated String ($): Variablen und Ausdrücke können direkt in einen Text eingefügt werden.
        - string name = "Ivan";
          WriteLine($"Hallo {name}");

4. Why should you be careful when using float and double values?
    - Weil viele Dezimalzahlen nicht exakt als binäre Gleitkommazahlen gespeichert werden können.
      Es können minimale Rundungsabweichungen entstehen.
      Merksatz: Für Geldbeträge normalerweise decimal verwenden.

5. How can you determine how many bytes a type like double uses in memory?
    - Mit sizeof():
 
6. When should you use the var keyword?
    - Wenn der Datentyp aus der Wertzuweisung eindeutig erkennbar ist.

7. What is the newest syntax to create an instance of a class like XmlDocument?
    - XmlDocument xml = new XmlDocument(); --> XmlDocument xml = new();

8. Why should you be careful when using the dynamic type?
    - Weil der Compiler nicht überprüft, ob die verwendeten Methoden und Eigenschaften tatsächlich existieren.
      Der Code kann kompiliert werden, verursacht aber beim Ausführen einen Fehler.

9. How do you right-align a format string?
    - Durch eine positive Breitenangabe:
      WriteLine($"|{"Hallo",10}|");

10. What character separates arguments for a console app?
    - Ein Leerzeichen.
      dotnet run -- red yellow 50
*/