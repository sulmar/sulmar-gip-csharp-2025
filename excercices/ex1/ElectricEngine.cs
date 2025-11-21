namespace Vehicles
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine()
        {
            Type = "Electric";
        }

        public override string GetEngineInfo()
        {
            return $"Electric Engine - Power: {Power} HP, Type: {Type}";
        }
    }
}

