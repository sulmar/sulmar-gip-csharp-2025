namespace ProxyPattern;

internal class ProductController
{
    private readonly IProductRepository repository;

    public ProductController(IProductRepository repository)
    {
        this.repository = repository;
    }

    public Product Get(int id)
    {
        Product product = repository.Get(id);

        return product;
    }
}
