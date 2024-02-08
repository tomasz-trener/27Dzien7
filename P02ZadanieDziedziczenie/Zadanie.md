Wersja podstawowa:
Tworzysz program do generowania raportów w postaci plików: .CSV, .HTML, .SQL. 
Każdy z plików posiada zawartość, rozmiar, autora, ścieżkę, nazwę. 
Każdy z plików to powinna być osobna klasa. Każdy z plików posiada także metodę „Zapisz”, 
która zapisuje plik na dysk w miejsce ścieżki (własnej). 
Plik na dysk zostaje zapisany z właściwym rozszerzeniem, tj. HTML ma rozszerzenie .HTML itd. 
Zawartość pliku także może być różna. Stwórz klasy szczegółowe i ogólne korzystając z dziedziczenia. 
Stwórz przykładowych 5 plików HTML, 4 CSV i 3 SQL. 
Następnie umieść wszystkie pliki w kolekcji i zapisz na dysk każdy plik w pętli.

Wersja Rozszerzona:
Każdy plik formatuje zawartość w odpowiedni dla siebie sposób, czyli:
Na przykład, plik HTML wygeneruje zawartość:
```html
<html>
<body>
<p>Ala ma kota</p>
</body>
</html>
```
Plik CSV wygeneruje zawartość: 
```
ala,ma,kota
```
Plik SQL wygeneruje:
```sql
SELECT ala ma kota FROM dane
```
Zakładając, że zawartość każdego pliku to "ala ma kota".