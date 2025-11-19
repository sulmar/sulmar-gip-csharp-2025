
Console.Write("Podaj imie: ");
var firstName = Console.ReadLine();

Console.Write("Podaj nazwisko: ");
var lastName = Console.ReadLine();

// zla praktyka
// string message = firstName + " " + lastName;

// dobra praktyka
string message = $"{firstName} {lastName}"; // Interpolacja 

Console.WriteLine(message);

Console.WriteLine($"{firstName} {lastName}"); // wersja skrocona