### Zadanie: Implementacja wyszukiwarki osób (trenerów i zawodników) w aplikacji

#### Cel zadania:
Celem zadania jest rozbudowa istniejącej aplikacji o funkcjonalność wyszukiwarki, która pozwoli na szybkie odnalezienie trenerów i zawodników po fragmencie ich imienia lub nazwiska. Wyszukiwarka powinna korzystać z jednolitej listy obiektów, łącząc trenerów i zawodników, i wyświetlać szczegółowe informacje o znalezionych osobach.

#### Wymagania funkcjonalne:
1. **Klasa bazowa i dziedziczenie**:
   - Stwórz klasę bazową, np. `Osoba`, która będzie zawierała wspólne atrybuty i metody dla trenerów i zawodników (np. imię, nazwisko, kraj pochodzenia, data urodzenia).
   - Zmodyfikuj klasy `Trener` i `Zawodnik` tak, aby dziedziczyły po klasie `Osoba`.

2. **Formularz wyszukiwarki**:
   - Dodaj przycisk "Wyszukiwarka" do głównego interfejsu aplikacji, który otworzy nowy formularz zawierający pole tekstowe do wprowadzania zapytania wyszukiwania.
   - W formularzu wyszukiwarki zaimplementuj funkcję wyszukiwania osób (trenerów i zawodników) po wpisaniu fragmentu imienia lub nazwiska.

3. **Wyświetlanie wyników i ich szczegółów**:
   - Wyniki wyszukiwania powinny być wyświetlane w formie listy lub tabeli poniżej pola tekstowego.
   - Dla każdego wyniku, dynamicznie generuj kontrolki wyświetlające szczegóły osoby, takie jak kraj pochodzenia (jeśli dostępny) i data urodzenia.

4. **Sortowanie wyników**:
   - Wyniki wyszukiwania powinny być posortowane według pory roku urodzenia, zaczynając od wiosny i kończąc na zimie. Użyj do tego celu metody `Array.Sort` oraz interfejsu `IComparable`.

 