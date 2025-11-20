// See https://aka.ms/new-console-template for more information
using GenericClassConsoleApp;
using GenericInterfaceConsoleApp;

Console.WriteLine("Hello, World!");

ICustomerRepository repository = new FakeCustomerRepository(new List<Customer>());

var customers = repository.GetAll();

foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
}