// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Console.WriteLine("Hello, World!");

ProductController controller = new ProductController(new DbProductRepository(), new CacheProductRepository());

var product = controller.Get(1);
Console.WriteLine(product);

product = controller.Get(1);
Console.WriteLine(product);

product = controller.Get(1);
Console.WriteLine(product);