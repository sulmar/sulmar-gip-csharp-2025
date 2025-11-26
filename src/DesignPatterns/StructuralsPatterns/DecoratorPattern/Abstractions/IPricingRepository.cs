namespace DecoratorPattern.Abstractions;

interface IPricingRepository
{
    decimal GetPrice(int productId);
}


