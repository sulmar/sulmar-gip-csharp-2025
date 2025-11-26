namespace DecoratorPattern.Abstractions;

interface IDiscountRepository
{
    decimal Get(string category);
}


