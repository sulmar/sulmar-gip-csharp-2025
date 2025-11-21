namespace Vehicles
{
    public class HybridCar : Car
    {
        public CombustionEngine CombustionEngine { get; set; }
        public ElectricEngine ElectricEngine { get; set; }
        public decimal FuelTankCapacity { get; set; }
        public decimal BatteryCapacity { get; set; }

        public override Engine Engine => ElectricEngine;

        public override string GetInfo()
        {
            return $"Hybrid Car: {Brand} {Model} ({ProductionYear}) - " +
                   $"Combustion: {CombustionEngine.GetEngineInfo()}, " +
                   $"Electric: {ElectricEngine.GetEngineInfo()}, " +
                   $"Fuel Tank Capacity: {FuelTankCapacity}L, " +
                   $"Battery Capacity: {BatteryCapacity}kWh";
        }
    }
}

