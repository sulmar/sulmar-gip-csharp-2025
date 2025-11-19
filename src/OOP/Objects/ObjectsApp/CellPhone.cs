namespace GIP.Warehouse;

public class CellPhone : Phone
{
    public Battery? Battery { get; set; }

    public CellPhone(string model, string manufacture = "Nokia", Battery battery = null) 
        : base(model, manufacture)
    {
        this.Battery = battery;
    }

    public override string ToString()
    {
        return GetFullName();
    }

    public string GetFullName()
    {
        return $"{base.ToString()} battery: {Battery}";
    }
}
