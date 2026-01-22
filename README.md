# Projekt: Ewidencja Pojazdów

Zintegrowany system do zarządzania flotą pojazdów, składający się z aplikacji desktopowej oraz nowoczesnego panelu webowego. Projekt zrealizowany na zajęcia z projektowania interfejsów użytkownika.

## Technologie
* **Desktop:** C#, .NET Framework, WinForms, Microsoft Reporting Services (RDLC).
* **Web:** HTML5, CSS3 (Bootstrap 5), JavaScript (ES6), LocalStorage.
* **Stylistyka:** Cyberpunk / Dark Mode.

## Funkcje systemu

### Część desktopowa WindowsForms
* **Ewidencja:** Dodawanie pojazdów do dynamicznej listy (`BindingList`).
* **Walidacja:** Obsługa danych takich jak numer rejestracyjny, marka, model, rok produkcji oraz data przeglądu.
* **Raportowanie:** Generowanie profesjonalnych raportów RDLC. 
* **Filtracja:** Automatyczne filtrowanie raportu pod kątem przeglądów kończących się w bieżącym miesiącu.

### Część webowa 
* **Zarządzanie:** Pełny CRUD w przeglądarce.
* **Responsywność:** Interfejs oparty o Bootstrap 5, dostosowany do urządzeń mobilnych.
* **Trwałość danych:** Wykorzystanie `localStorage` do zapamiętywania wpisów po odświeżeniu strony.
* **Design:** Neonowa stylistyka z interaktywnymi elementami (hover effects).

## Jak uruchomić
1. **Aplikacja desktopowa:** 
Otwórz plik `EwidencjaPojazdow.sln` w Visual Studio i uruchom projekt poprzez wciśnięcie F5.
2. **Strona WWW:** 
Otwórz plik `EwidencjaWeb/index.html` w dowolnej przeglądarce.

## Struktura folderów
* `/EwidencjaPojazdow` - Kod źródłowy aplikacji WinForms.
* `/EwidencjaWeb` - Pliki strony internetowej (HTML/JS).
* `EwidencjaPojazdow.sln` - Główny plik rozwiązania Visual Studio.
