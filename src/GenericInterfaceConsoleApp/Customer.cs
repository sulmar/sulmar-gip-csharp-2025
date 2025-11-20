using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceConsoleApp;

public abstract class Base
{
    public int Id { get; set; }
}

public class Customer : Base
{
    public string Name { get; set; }
}

public class Vehicle : Base
{
    public string Vin { get; set; }
    public string Color { get; set; }
}

public class Person : Base
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public interface ICustomerRepository : IEntityRepository<Customer>
{
}
 
// Interfejs generyczny (szablon interfejsu)
public interface IEntityRepository<TEntity> 
    where TEntity : Base
{
    List<TEntity> GetAll();
    TEntity Get(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(int id);   
}


public interface IVehicleRepository : IEntityRepository<Vehicle>
{
    List<Vehicle> GetByColor(string color);
    Vehicle GetByVin(string vin);
}

public interface IPersonRepository : IEntityRepository<Person>
{
    List<Person> GetByPesel(string pesel);
}

