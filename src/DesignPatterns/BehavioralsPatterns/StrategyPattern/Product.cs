namespace StrategyPattern;

internal class Product
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public Unit Unit { get; set; }
}

enum Unit
{
    szt,
    m2,
    kg
}

class ProductCalculator
{
    private IPricingStrategy strategy;

    public ProductCalculator()
        : this(new PerUnitPricingStrategy())
    {        
    }

    public void SetStrategy(IPricingStrategy strategy)
    {
        this.strategy = strategy;
    }

    public ProductCalculator(IPricingStrategy strategy)
    {
        this.strategy = strategy;
    }

    public decimal CalculatePrice(Product product, decimal quantity)
    {
        return strategy.CalculatePrice(product, quantity);
    }
}

// Abstract Strategy
interface IPricingStrategy
{
    decimal CalculatePrice(Product product, decimal quantity);
}

// Concrete Strategy A
class PerUnitPricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(Product product, decimal quantity)
    {
        return product.UnitPrice * quantity;
    }
}

// Concrete Strategy B
class PerSquarePricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(Product product, decimal squereMeters)
    {
        return product.UnitPrice * squereMeters;
    }
}


// Concrete Strategy C
class OpenDoorPricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(Product product, decimal quantity)
    {
        return quantity * 10m;
    }
}

// Decorator Strategi
class DiscountPricingStrategy : IPricingStrategy
{
    // Decoratee
    private IPricingStrategy pricingStrategy;

    public DiscountPricingStrategy(IPricingStrategy pricingStrategy)
    {
        this.pricingStrategy = pricingStrategy;
    }

    public decimal CalculatePrice(Product product, decimal quantity)
    {
        return pricingStrategy.CalculatePrice(product, quantity) * (1 - 0.1m);
    }
}
