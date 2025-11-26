namespace StrategyPattern;

internal class Product
{   
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
}

class ProductCalculator
{
    public decimal CalculatePrice(Product product, decimal quantity)
    {
        return product.UnitPrice * quantity;
    }
}
