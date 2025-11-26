using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Application;

// Decorator
class DiscountProductDecorator : IPricingRepository
{
    private readonly IPricingRepository _repository;
    private readonly IDiscountRepository _discountRepository;

    public DiscountProductDecorator(IPricingRepository repository, IDiscountRepository discountRepository)
    {        
        this._repository = repository;
        this._discountRepository = discountRepository;
    }

    public decimal GetPrice(int productId)
    {
        decimal price = _repository.GetPrice(productId);
        decimal discount = _discountRepository.Get("a");

        return  price * (1 - discount);
    }
}


