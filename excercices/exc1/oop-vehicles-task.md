# ✅ Zadanie: Modelowanie pojazdów w C#

## 🧩 Cel:
Celem zadania jest zaprojektowanie zestawu powiązanych ze sobą klas w C#, tak aby można było tworzyć różne typy samochodów (spalinowy, elektryczny, hybrydowy) oraz ich elementy składowe. Zadanie ma pomóc w utrwaleniu umiejętności tworzenia struktur klas i rozszerzania ich o dodatkowe cechy.

---

## ✅ Wymagania funkcjonalne

A. Każdy samochód powinien mieć:
- Brand
- Model 
- Rok produkcji
- Silnik
- Metodę `GetInfo()` zwracającą podstawowe informacje o samochodzie
    
B. Silnik powinien zawierać:
-	Power (moc w KM)
-	Capacity (pojemność)
-	Type (string – np. „Gasoline”, „Electric”)
-	metodę GetEngineInfo()

C. Typy samochodów
1. Samochod spalinowy
    - FuelTankCapacity (pojemnosc baku)
	
2. Samochod elektryczny
	-	BatteryCapacity (pojemnosc baterii)

3. Samochód hybrydowy
	-	zamiast jednego silnika posiada dwa:
	-	silnik spalinowy
	-	silnik elektryczny
	-	metoda GetInfo() powinna prezentować oba elementy napędu

D. Program testowy

W metodzie Main() utwórz:
	-	jeden samochód spalinowy
	-  jeden elektryczny
	-	jeden hybrydowy
	-	wyświetl informacje o każdym obiekcie za pomocą GetInfo()

---

## ⏱️ Czas realizacji: 45 minut

⏱ 45 minut