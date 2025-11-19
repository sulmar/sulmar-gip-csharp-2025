
Console.Write("Podaj imie: ");
var firstName = Console.ReadLine();

Console.Write("Podaj nazwisko: ");
var lastName = Console.ReadLine();

byte age = 30; // 0..255
Console.Write("Podaj wiek: ");

// Nullable
decimal? salary = null;

if (salary.HasValue)
{
    Console.WriteLine($"Salary {salary}");
}

const byte AdultAge = 18;

// Konwersja typów
age = byte.Parse(Console.ReadLine());

if (byte.TryParse(Console.ReadLine(), out age)) // out - parametr wyjsciowy
{
    // zla praktyka
    // string message = firstName + " " + lastName;

    // dobra praktyka
    string message = $"{firstName} {lastName}"; // Interpolacja 

    Console.WriteLine(message);

    Console.WriteLine($"imie: {lastName} nazwisko: {firstName} wiek: {age}"); // wersja skrocona
}
else
{
    Console.WriteLine("Podano nieprawidlowy wiek");
}


if (age >= AdultAge)  
{
    Console.WriteLine("Dozwolone");
}
else
{
    Console.WriteLine("Niedozwolone.");
}


// Rzutowanie typow

// Konwersja jawna (stratna)
double latitude = 26.01;
int lat = (int) latitude;

// Konwersja niejawna (bezstratna)
int longitude = 52;
double lng = longitude;



