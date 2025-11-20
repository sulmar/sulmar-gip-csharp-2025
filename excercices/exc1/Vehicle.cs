namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int ProductionYear { get; set; }

        public abstract string GetInfo();
    }
}

