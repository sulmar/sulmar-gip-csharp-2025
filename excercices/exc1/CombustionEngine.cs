namespace Vehicles
{
    public class CombustionEngine : Engine
    {
        public decimal Capacity { get; set; }

        public CombustionEngine()
        {
            Type = "Gasoline";
        }

        public override string GetEngineInfo()
        {
            return $"Combustion Engine - Power: {Power} HP, Capacity: {Capacity}L, Type: {Type}";
        }
    }
}

