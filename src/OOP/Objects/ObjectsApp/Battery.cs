namespace GIP.Warehouse;

public class Battery
{
    public float Capacity;
    public float Level; // 0 = 0% 0.5 = 50% 1 = 100% 

    // konstruktor
    public Battery()
    {
        Level = 1;
    }

    private string GetFullName()
    {
        return $"capacity: {Capacity} level: {Level:P2}";
    }

    public override string ToString()
    {
        return GetFullName();
    }


}
