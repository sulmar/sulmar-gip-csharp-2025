namespace DecoratorPattern.Domain.Abstractions;

interface IDiscountRepository
{
    decimal Get(string category);
}


