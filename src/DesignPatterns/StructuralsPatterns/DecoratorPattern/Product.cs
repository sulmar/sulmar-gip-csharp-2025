namespace DecoratorPattern;

internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }    
}

class ProductCalculator
{
    private readonly IPricingRepository pricingRepository;

    public ProductCalculator(IPricingRepository pricingRepository)
    {
        this.pricingRepository = pricingRepository;
    }

    public decimal Calculate(Product product, int quantity)
    {
        return pricingRepository.GetPrice(product.Id) * quantity;
    }
}


