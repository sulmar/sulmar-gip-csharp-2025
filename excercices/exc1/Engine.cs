namespace Vehicles
{
    public abstract class Engine
    {
        public decimal Power { get; set; }
        public string Type { get; set; } = string.Empty;

        public abstract string GetEngineInfo();
    }
}

