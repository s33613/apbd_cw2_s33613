Instrukcja uruchomienia:

1.Uruchom Program.cs
2.Po uruchomieniu automatycznie zobaczysz automatycznie zrobione c 
3.Wpisz nazwe użytkownika "Mike" dla profilu studenta lub "JohnWorker" dla profilu pracownika
4.Wpisz haslo "SecuredPass" dla bazowego studenta lub "Password" dla bazowego pracownika
Aby wyłączyć interaktywny aspekt programu wystarczy zakomentować metode InteractiveUse

Decyzje Podjęte w czasie projektu:
Klasy przedmiotów dziedziczą po bazowej klasie abstrakcyjnej Item.cs dzięki czemu wszystkie przedmioty
mają niezbędne metody i pola. W tej klasie również znajduje się statyczna lista wszystkich przedmiotów
pozwalająca na przeglądanie dodanych przedmiotów bez korzystania ze zmiennych.
Klasy użytkowników również dziedziczą po bazowej klasie abstrakcyjnej User.cs dzięki czemu w statycznej
liście użytkowników możemy znaleźć danego użytkownika i potwierdzić jego tożsamość poprzez hasło.
Klasy Item i User są łączone w klasie RentingManager.cs zarządzającej poszczególnymi wypożyczeniami
poprzez obiekty klasy rent.