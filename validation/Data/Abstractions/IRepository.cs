namespace validation.Data.Abstractions;

public interface IRepository<out T> : IRepository where T : IEntity
{
    new T? Find(int id);
}


public interface IRepository
{
    object? Find(int id);
}