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

List<Customer> results = new List<Customer>();

foreach (var customer in customers)
{
    if (customer.Salary > 100)  // Predykat
    {
        results.Add(customer);
    }
}

Console.WriteLine("Znaleziono: ");
foreach (var customer in results)
{
    Console.WriteLine(customer);
}












