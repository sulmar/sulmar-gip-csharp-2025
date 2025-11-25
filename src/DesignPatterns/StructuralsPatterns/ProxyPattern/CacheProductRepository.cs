namespace ProxyPattern;

// Proxy Design (Posrednik)
// Wariant obiektowy

class CacheProductRepository : IProductRepository
{
    private readonly IDictionary<int, Product> _cache = new Dictionary<int, Product>();

    // Real Subject
    private readonly IProductRepository _repository;

    public CacheProductRepository(IProductRepository repository)
    {
        _repository = repository;
    }

    public void Add(Product product)
    {
        _cache.Add(product.Id, product);
    }

    public Product Get(int id)
    {
        if (_cache.TryGetValue(id, out var product))
        {
            product.CacheHit++;

            return product;
        }

        product = _repository.Get(id); // Real Subject

        if (product != null)
        {
            Add(product);
        }

        return product;
        
    }
}


