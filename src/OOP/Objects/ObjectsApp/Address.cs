namespace ObjectsApp;

public class Address
{
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Street { get; set; }
    public string FullAddress
    {
        get
        {
            return $"{Street} {PostalCode} {Country}";
        }
    }

    public override string ToString()
    {
        return FullAddress;
    }

}

