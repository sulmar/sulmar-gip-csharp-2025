namespace Vehicles
{
    public class CombustionCar : Car
    {
        public decimal FuelTankCapacity { get; set; }
        public CombustionEngine CombustionEngine { get; set; }

        public override Engine Engine => CombustionEngine;

        public override string GetInfo()
        {
            return $"Combustion Car: {Brand} {Model} ({ProductionYear}) - {Engine.GetEngineInfo()}, Fuel Tank Capacity: {FuelTankCapacity}L";
        }
    }
}

