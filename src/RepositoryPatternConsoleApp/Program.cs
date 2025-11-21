
using RepositoryPatternConsoleApp.Controllers;

Console.WriteLine("Hello, World!");

CustomersController controller = new CustomersController(new CsvFileCustomerRepository("customers.csv"));

var customers = controller.Get();


foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
}