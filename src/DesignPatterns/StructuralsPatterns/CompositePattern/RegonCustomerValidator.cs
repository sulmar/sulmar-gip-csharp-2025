namespace CompositePattern;

class RegonCustomerValidator : ICustomerValidator
{
    public bool IsValid(Customer customer)
    {
        return customer.Regon.Length == 9 || customer.Regon.Length == 14;
    }
}
