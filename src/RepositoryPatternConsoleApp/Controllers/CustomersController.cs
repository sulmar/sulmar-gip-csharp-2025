using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternConsoleApp.Controllers;

class CustomersController : Controller
{
    private readonly ICustomerRepository _repository;
    public CustomersController(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public List<Customer> Get()
    {
        return _repository.GetAll();
    }
}
