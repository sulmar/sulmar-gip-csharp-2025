// See https://aka.ms/new-console-template for more information
using CollectionConsoleApp;

Console.WriteLine("Hello, World!");

var customer1 = new Customer { Id = 1, Name = "a", Risk = RiskType.High, Salary = 100 };
var customer2 = new Customer { Id = 2, Name = "b", Risk = RiskType.Low, Salary = 150 };
var customer3 = new Customer { Id = 3, Name = "c", Risk = RiskType.Low, Salary = 50 };
var customer4 = new Customer { Id = 4, Name = "e", Risk = RiskType.Low, Salary = 150 };
var customer5 = new Customer { Id = 5, Name = "f", Risk = RiskType.Middle, Salary = 10 };

int x = 10; // pojedyncza wartosc

// Tablica
int[] vector = new int[3] { 1, 2, 4 }; // wektor (tablica jednowymiarowa)

// zla praktyka 
//Customer[] customers = new Customer[1_000_000];
//customers[0] = customer1;
//customers[1] = customer2;
//customers[2] = customer3;


// Kolekcja
List<Customer> customers = new List<Customer>();
customers.Add(customer1);
customers.Add(customer2);
customers.Add(customer3);
customers.Add(customer4);
customers.Add(customer5);

customers.Remove(customer3);

foreach (Customer customer in customers)
{
    Console.WriteLine(customer);
}

Console.WriteLine(customers.Count);

// TODO: Pokaz klientow ktorych dochod wynosi powyzej 100 zl


// Zapis imperatywny
List<Customer> results = new List<Customer>();

foreach (var c in customers)
{
    if (c.Salary > 100)  // Predykat
    {
        results.Add(c);
    }
}

// Zapis deklaratywny
// SQL: SELECT * FROM Customers AS c WHERE c.Salary > 100;

// Zapis deklaratywny 
results = customers.Where(c => c.Salary > 100).ToList(); // c - lokalna zmiennia


Console.WriteLine("Znaleziono: ");
foreach (var customer in results)
{
    Console.WriteLine(customer);
}

// TODO: Pokaz klientow ktorzy Risk maja Wysokie
results.Clear();

foreach (var customer in customers)
{
    if (customer.Risk == RiskType.High)  // Predykat
    {
        results.Add(customer);
    }
}

// SQL: SELECT * FROM Customers WHERE Risk = 2;
results = customers.Where(c => c.Risk == RiskType.High).ToList();

Console.WriteLine("Znaleziono: ");
foreach (var customer in results)
{
    Console.WriteLine(customer);
}




// SQL: SELECT * FROM Customers WHERE c.Salary > 100 AND c.Risk = 2;

// LINQ (zbior metod rozszerzajacych interfejs IEnumerable<T>)

results = customers.Where(c => c.Salary > 100 && c.Risk == RiskType.High).ToList();

results = customers
    .Where(c => c.Salary > 100)
    .Where(c => c.Risk == RiskType.High)
    .ToList();


// SQL: SELECT * FROM Customers WHERE c.Salary > 100 OR c.Risk = 2;
results = customers.Where(c => c.Salary > 100 || c.Risk == RiskType.High).ToList();

var riskResults = customers.GroupBy(c => c.Risk).ToList();

foreach (var group in riskResults)
{
    Console.WriteLine(group.Key);

    foreach (var customer in group)
    {
        Console.WriteLine(customer);
    }
}

// TODO: ilu jest klientow w poszczegolnych grupach ryzyka
// SQL: SELECT Risk AS Ryzyko, COUNT(*) AS Liczba FROM Customers GROUP BY Risk ORDER BY Risk

var riskCountResults = customers
    .GroupBy(c => c.Risk)
    .Select(g => new { Ryzyko = g.Key, Liczba = g.Count() }) // Zastosowanie typu anonimowego
    .OrderBy(g => g.Ryzyko)
    .ToList();

Console.WriteLine();


// Typ anonimowy
var info = new { Temperature = -1f, Humidity = 0.97f, Description = "Pada snieg" };

Console.WriteLine(info.Humidity);


/*
 class f__AnonymousType0
{
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public string Description { get; set; }
}
*/









