namespace Vehicles
{
    public abstract class Car : Vehicle
    {
        public abstract Engine Engine { get; }

        public override string GetInfo()
        {
            return $"Car: {Brand} {Model} ({ProductionYear}) - {Engine.GetEngineInfo()}";
        }
    }
}

