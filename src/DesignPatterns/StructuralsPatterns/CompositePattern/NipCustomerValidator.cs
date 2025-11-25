namespace CompositePattern;

class NipCustomerValidator : ICustomerValidator
{
    public bool IsValid(Customer customer)
    {
        return customer.Nip.Length == 13;
    }
}
