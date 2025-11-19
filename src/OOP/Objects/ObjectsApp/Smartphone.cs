namespace GIP.Warehouse;

public class Smartphone : CellPhone // Dziedzinie (inheritance)
{
    public Smartphone(string model, TouchScreen touchScreen, string manufacture = "Apple", Battery battery = null) 
        : base(model, manufacture, battery)
    {
        this.TouchScreen = touchScreen;

        isPowerOn = true;
       
    }

    public TouchScreen TouchScreen { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} {TouchScreen}";
    }
}
