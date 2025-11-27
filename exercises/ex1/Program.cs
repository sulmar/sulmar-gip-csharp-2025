namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Samochód spalinowy
            var combustionCar = new CombustionCar
            {
                Brand = "Toyota",
                Model = "Corolla",
                ProductionYear = 2023,
                FuelTankCapacity = 50m,
                CombustionEngine = new CombustionEngine
                {
                    Power = 150m,
                    Capacity = 2.0m
                }
            };

            // Samochód elektryczny
            var electricCar = new ElectricCar
            {
                Brand = "Tesla",
                Model = "Model 3",
                ProductionYear = 2024,
                BatteryCapacity = 75m,
                ElectricEngine = new ElectricEngine
                {
                    Power = 283m
                }
            };

            // Samochód hybrydowy
            var hybridCar = new HybridCar
            {
                Brand = "Toyota",
                Model = "Prius",
                ProductionYear = 2024,
                FuelTankCapacity = 43m,
                BatteryCapacity = 1.3m,
                CombustionEngine = new CombustionEngine
                {
                    Power = 98m,
                    Capacity = 1.8m
                },
                ElectricEngine = new ElectricEngine
                {
                    Power = 72m
                }
            };

            // Wyświetlanie informacji
            Console.WriteLine("=== Informacje o pojazdach ===\n");
            
            Console.WriteLine("1. Samochód spalinowy:");
            Console.WriteLine(combustionCar.GetInfo());
            Console.WriteLine();

            Console.WriteLine("2. Samochód elektryczny:");
            Console.WriteLine(electricCar.GetInfo());
            Console.WriteLine();

            Console.WriteLine("3. Samochód hybrydowy:");
            Console.WriteLine(hybridCar.GetInfo());
        }
    }
}

