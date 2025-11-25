namespace CompositePattern;

class ActionResult { }

class BadRequestObjectResult : ActionResult 
{
    private readonly string message;

    public BadRequestObjectResult(string message)
    {
        this.message = message;
    }

    public override string ToString()
    {
        return message;
    }
}

class CreatedResult : ActionResult {

    public override string ToString()
    {
        return "Created.";
    }

}

class Customer 
{
    public string Nip { get; set; }
    public string Regon { get; set; }
}

interface ICustomerValidator
{
    bool IsValid(Customer customer);
}

class NipCustomerValidator : ICustomerValidator
{
    public bool IsValid(Customer customer)
    {
        return customer.Nip.Length == 13;
    }
}

class RegonCustomerValidator : ICustomerValidator
{
    public bool IsValid(Customer customer)
    {
        return customer.Regon.Length == 9 || customer.Regon.Length == 14;
    }
}

internal class CustomerController
{
    private readonly ICustomerValidator[] _validators;

    public CustomerController(ICustomerValidator[] validators)
    {
        _validators = validators;
    }

    public ActionResult Post(Customer customer)
    {
        foreach (ICustomerValidator validator in _validators)
        {
            if (!validator.IsValid(customer))
            {
                return new BadRequestObjectResult("Invalid customer data");
            }
        }

        return new CreatedResult();
    }
}
