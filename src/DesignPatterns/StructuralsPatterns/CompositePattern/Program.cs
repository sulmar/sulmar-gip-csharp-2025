// See https://aka.ms/new-console-template for more information
using CompositePattern;

Console.WriteLine("Hello, World!");

Customer validCustomer = new Customer { Nip = "0123456789123", Regon = "123456789" };
Customer invalidCustomer = new Customer { Nip = "012345678912", Regon= "123" };

CustomerController controller = new CustomerController(
    new List<ICustomerValidator> { new RegonCustomerValidator() }.ToArray());

var result = controller.Post(invalidCustomer);

Console.WriteLine(result);

