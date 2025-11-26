using DecoratorPattern.Domain.Abstractions;

namespace DecoratorPattern.Infrastructures;

class FakeDiscountRepository : IDiscountRepository
{
    public decimal Get(string category)
    {
        return 0.2m;
    }
}


