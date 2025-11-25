// See https://aka.ms/new-console-template for more information
using CompositePattern;

Console.WriteLine("Hello, World!");

Customer validCustomer = new Customer { Nip = "0123456789123" };
Customer invalidCustomer = new Customer { Nip = "012345678912" };

CustomerController controller = new CustomerController(new NipCustomerValidator());

var result = controller.Post(validCustomer);

Console.WriteLine(result);

