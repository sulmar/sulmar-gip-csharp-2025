namespace GIP.Warehouse;

public class Battery
{
    public float Capacity;
    public float Level; // 0 = 0% 0.5 = 50% 1 = 100% 

    public const float MaxLevel = 1;


    // konstruktor
    public Battery()
    {
        Level = 1;
    }

    public void Charge(float delta)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(delta);

        //if (delta <= 0)
        //{
        //    throw new ArgumentOutOfRangeException("delta");
        //}
        
        if (Level + delta > MaxLevel)
        {
            throw new Exception($"Nie mozna naladowac powyzej poziom maks. {MaxLevel:P0}");
        }

        // Level = Level + delta;
        Level += delta;

      
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
