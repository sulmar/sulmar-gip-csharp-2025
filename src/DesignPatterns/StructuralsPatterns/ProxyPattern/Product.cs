namespace ProxyPattern;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int CacheHit { get; set; }

    public override string ToString()
    {
        return $"{Id} {Name} CacheHit: {CacheHit}";
    }
}
