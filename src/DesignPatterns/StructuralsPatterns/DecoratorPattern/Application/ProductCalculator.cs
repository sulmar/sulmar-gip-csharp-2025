using DecoratorPattern.Abstractions;
using DecoratorPattern.Models;

namespace DecoratorPattern.Application;

class ProductCalculator
{
    private readonly IPricingRepository pricingRepository;

    public ProductCalculator(IPricingRepository pricingRepository)
    {
        this.pricingRepository = pricingRepository;
    }

    public decimal Calculate(Product product, int quantity)
    {
        var price = pricingRepository.GetPrice(product.Id);

        return price * quantity;
    }
}


