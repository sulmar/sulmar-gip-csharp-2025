using GenericInterfaceConsoleApp;

namespace GenericClassConsoleApp;

// Klasa generyczna (Szablon klasy) 
internal class FakeEntityRepository<TEntity> : IEntityRepository<TEntity>
    where TEntity : Base
{
    protected readonly List<TEntity> entities;

    public FakeEntityRepository(List<TEntity> entities)
    {
        this.entities = entities;
    }

    public void Add(TEntity entity)
    {
        entities.Add(entity);
    }

    public TEntity Get(int id)
    {
        return entities[id];
    }

    public List<TEntity> GetAll()
    {
        return entities;
    }

    public void Remove(int id)
    {
        entities.Remove(Get(id));
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}


