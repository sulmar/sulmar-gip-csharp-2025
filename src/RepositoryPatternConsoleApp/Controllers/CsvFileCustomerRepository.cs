namespace RepositoryPatternConsoleApp.Controllers;

class CsvFileCustomerRepository : ICustomerRepository
{
    private readonly string _fileName;

    public CsvFileCustomerRepository(string fileName)
    {
        _fileName = fileName;
    }

    public List<Customer> GetAll()
    {
       string[] lines = File.ReadAllLines(_fileName);   

        List<Customer> customers = new List<Customer>();

        foreach (var line in lines)
        {
            Customer customer = new Customer { Name = line };
            customers.Add(customer);
        }

        return customers;


    }
}
