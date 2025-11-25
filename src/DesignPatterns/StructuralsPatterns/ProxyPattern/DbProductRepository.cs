namespace ProxyPattern;

class DbProductRepository
{
    private readonly IDictionary<int, Product> _products;

    public DbProductRepository()
    {
        _products = new Dictionary<int, Product>()
        {
            { 1, new Product() { Id = 1, Name = "a" } },
            { 2, new Product() { Id = 2, Name = "b" } },
            { 3, new Product() { Id = 3, Name = "c" } }
        };
    }

    public Product Get(int id)
    {
        Thread.Sleep(2000);

        if (_products.TryGetValue(id, out var product))
        {
            return product;
        }

        else return null;
    }
}

class CacheProductRepository
{
    private readonly IDictionary<int, Product> _products = new Dictionary<int, Product>();

    public void Add(Product product)
    {
        _products.Add(product.Id, product);
    }

    public Product Get(int id)
    {
        if (_products.TryGetValue(id, out var product))
        {
            product.CacheHit++;

            return product;
        }

        else
            return null;
    }


}
