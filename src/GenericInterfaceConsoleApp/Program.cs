// See https://aka.ms/new-console-template for more information
using GenericInterfaceConsoleApp;

Console.WriteLine("Hello, World!");


ICustomerRepository repository = null;

var customers = repository.GetAll();

foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
}