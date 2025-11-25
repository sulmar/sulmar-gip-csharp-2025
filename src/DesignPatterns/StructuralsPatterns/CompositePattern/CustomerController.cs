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

internal class CustomerController
{
    private readonly ICustomerValidator _validator;

    public CustomerController(ICustomerValidator validator)
    {
        _validator = validator;
    }

    public ActionResult Post(Customer customer)
    {
        if (!_validator.IsValid(customer))
        {
            return new BadRequestObjectResult("Invalid customer data");
        }

        return new CreatedResult();
    }
}
