namespace GIP.Warehouse;

public class Battery
{
    private float _capacity;
    public float Capacity
    {
        get
        {
            return _capacity;
        }

        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);

            _capacity = value;
        }

    }

    // backfield
    private float _level; // 0 = 0% 0.5 = 50% 1 = 100% 

    // Property (wlasciwosc)
    public float Level
    {
        get
        {
            return _level;
        }

        set
        {
            if (value > MaxLevel)
            {
                throw new Exception($"Nie mozna naladowac powyzej poziom maks. {MaxLevel:P0}");
            }

            _level = value;
        }
    }

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
