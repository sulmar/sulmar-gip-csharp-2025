using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceConsoleApp;

abstract class Base
{
    public int Id { get; set; }
}

class Customer : Base
{
    public string Name { get; set; }
}

class Vehicle : Base
{
    public string Vin { get; set; }    
}

class Person : Base
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

interface ICustomerRepository : IEntityRepository<Customer>
{
}
 
// Interfejs generyczny (szablon interfejsu)
interface IEntityRepository<TEntity> 
    where TEntity : Base
{
    List<TEntity> GetAll();
    TEntity Get(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(int id);   
}


interface IVehicleRepository : IEntityRepository<Vehicle>
{
    List<Vehicle> GetByColor(string color);
    Vehicle GetByVin(string vin);
}

interface IPersonRepository : IEntityRepository<Person>
{
    List<Person> GetByPesel(string pesel);
}

