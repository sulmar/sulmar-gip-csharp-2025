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
        var price = pricingRepository.GetPrice(product.Id);

        return price * quantity;
    }
}


