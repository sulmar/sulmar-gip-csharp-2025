namespace Vehicles
{
    public class ElectricCar : Car
    {
        public decimal BatteryCapacity { get; set; }
        public ElectricEngine ElectricEngine { get; set; }

        public override Engine Engine => ElectricEngine;

        public override string GetInfo()
        {
            return $"Electric Car: {Brand} {Model} ({ProductionYear}) - {Engine.GetEngineInfo()}, Battery Capacity: {BatteryCapacity}kWh";
        }
    }
}

