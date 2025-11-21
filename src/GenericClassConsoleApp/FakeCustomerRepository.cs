using GenericInterfaceConsoleApp;
using System.Drawing;

namespace GenericClassConsoleApp;

internal class FakeCustomerRepository : FakeEntityRepository<Customer>, ICustomerRepository
{
    private readonly List<Customer> customers;

    public FakeCustomerRepository(List<Customer> entities) : base(entities)
    {
    }
}


