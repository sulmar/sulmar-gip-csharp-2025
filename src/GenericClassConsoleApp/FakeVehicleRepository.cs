using GenericInterfaceConsoleApp;

namespace GenericClassConsoleApp;

class FakeVehicleRepository : FakeEntityRepository<Vehicle>, IVehicleRepository
{
    public FakeVehicleRepository(List<Vehicle> entities) : base(entities)
    {
    }

    public List<Vehicle> GetByColor(string color)
    {
        return entities.Where(v => v.Color == color).ToList();
    }

    public Vehicle GetByVin(string vin)
    {
        return entities.SingleOrDefault(v => v.Vin == vin);
    }
}


