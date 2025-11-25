// See https://aka.ms/new-console-template for more information
using CompositePattern;

Console.WriteLine("Hello, World!");

Customer validCustomer = new Customer { Nip = "0123456789123", Regon = "123456789" };
Customer invalidCustomer = new Customer { Nip = "012345678912", Regon= "123" };


 ICustomerValidator validator = new CompositeValidator(new RegonCustomerValidator(), new NipCustomerValidator());

// ICustomerValidator validator = new RegonCustomerValidator();

CustomerController controller = new CustomerController(validator);

var result = controller.Post(invalidCustomer);

Console.WriteLine(result);

