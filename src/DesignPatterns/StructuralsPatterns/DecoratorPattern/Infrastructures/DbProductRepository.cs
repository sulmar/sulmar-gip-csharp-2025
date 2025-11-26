using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Infrastructures;

class DbProductRepository : IPricingRepository
{
    public decimal GetPrice(int productId)
    {
        throw new NotImplementedException();
    }
}


