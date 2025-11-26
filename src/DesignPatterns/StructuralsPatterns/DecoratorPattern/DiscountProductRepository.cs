namespace DecoratorPattern;

// Decorator
class DiscountProductRepository : IPricingRepository
{
    private decimal discount;

    private readonly IPricingRepository _repository;

    public DiscountProductRepository(decimal discount, IPricingRepository repository)
    {
        this.discount = discount;
        this._repository = repository;
    }

    public decimal GetPrice(int productId)
    {
        return _repository.GetPrice(productId) * (1 - discount);
    }
}


