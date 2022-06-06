# :mortar_board: University Info 
Aplikacja ułatwiająca pracownikom uczelni dostęp do informacji o placówce. Aplikacja wykonuje operacje CRUD w na bazie danych uczelni.

## :white_check_mark: Funkcjonalności

### Operacje na danych

- Dodanie danych do tabeli
(W celu dodania danych uzupełniamy pola formularza **poza** polem `ID` które jest kluczem podstawowym typu autonumerowanego).
- Wyświetlenie danych z bazy danych odbywa się przez wpisanie `ID` i naciśnięciu przycisku `SZUKAJ`.
- Wyświetlenie wszystkich danych z tabeli odbywa się przez pozostawienie pola `ID` pustego i naciśnięcie przycisku `SZUKAJ`.
- Dodanie danych do tabeli odbywa się przez wpisanie danych **poza** polem `ID` i naciśnięcie przycisku `DODAJ`
- Edycja danych odbywa się poprzez wpisanie danych i wyborem `ID` studenta który jest edytowany, oraz wciśnięcie przycisku `EDYTUJ`
- Usuwanie danych odbywa się przez wybranie `ID` usuwanego rekordu oraz naciśnięcie przycisku `USUŃ`

Aplikacja posiada instaler `setup.exe`.

### Wykorzystane technologie

- Język programowania C#
- Pakiet `Microsoft Visual Studio Installer Projects` w celu utworzenia instalera programu
- Baza danych SQL (ADO.NET Entity Data Model) podejście **database first**
