namespace RepositoryPatternConsoleApp.Controllers;

class DbCustomerRepository : ICustomerRepository
{
    public List<Customer> GetAll()
    {
        string sql = "SELECT * FROM Customers";

        throw new NotImplementedException();
    }
}
