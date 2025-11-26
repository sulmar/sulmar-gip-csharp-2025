namespace DecoratorPattern.Domain.Abstractions;

interface IPricingRepository
{
    decimal GetPrice(int productId);
}


