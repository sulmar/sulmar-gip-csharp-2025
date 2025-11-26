using DecoratorPattern.Domain.Abstractions;
using DecoratorPattern.Domain.Models;

namespace DecoratorPattern.Infrastructures;

class FakeProductRepository : IPricingRepository
{
    private readonly Dictionary<int, Product> _products = new Dictionary<int, Product>
    {
        { 1, new Product { Id = 1, Name = "a", UnitPrice = 100 } },
        { 2, new Product { Id = 2, Name = "b", UnitPrice = 200 } },
        { 3, new Product { Id = 3, Name = "c", UnitPrice = 300 } }
    };

    public decimal GetPrice(int productId)
    {
       return _products[productId].UnitPrice;
    }
}


