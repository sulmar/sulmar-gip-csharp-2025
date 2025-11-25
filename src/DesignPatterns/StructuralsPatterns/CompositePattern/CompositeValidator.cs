namespace CompositePattern;

// Wzorzec Composite
class CompositeValidator : ICustomerValidator
{
    private readonly ICustomerValidator[] validators;

    public CompositeValidator(params ICustomerValidator[] validators)
    {
        this.validators = validators;
    }

    public bool IsValid(Customer customer)
    {
        return validators.All(validator => validator.IsValid(customer));
    }
}
