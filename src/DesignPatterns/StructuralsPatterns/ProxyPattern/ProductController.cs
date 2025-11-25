namespace ProxyPattern;

internal class ProductController
{
    private readonly DbProductRepository repository;
    private readonly CacheProductRepository cacheProductRepository;

    public ProductController(DbProductRepository repository, CacheProductRepository cacheProductRepository)
    {
        this.repository = repository;
        this.cacheProductRepository = cacheProductRepository;
    }

    public Product Get(int id)
    {
        Product product = cacheProductRepository.Get(id);

        if (product == null)
        {
            product = repository.Get(id);

            if (product != null)
            {
                cacheProductRepository.Add(product);
            }
        }

        return product;
    }
}
