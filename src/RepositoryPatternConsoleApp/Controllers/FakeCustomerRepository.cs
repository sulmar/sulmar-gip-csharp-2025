namespace RepositoryPatternConsoleApp.Controllers;

class FakeCustomerRepository : ICustomerRepository
{
    public List<Customer> GetAll()
    {
        return new List<Customer>()
        {
            new Customer() { Name = "John"},
            new Customer() { Name = "Doe"},
            new Customer() { Name = "Kate"},
        };
    }
}
