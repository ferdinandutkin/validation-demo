using validation.Data.Abstractions;
using validation.Data.Models;

namespace validation.Data.Repositories;

public class DuckRepository : IRepository<Duck>
{
    public Duck? Find(int id)
    {
        if (id > 3)
        {
            return new Duck() {Id = id};
        }

        return null;
    }

    object? IRepository.Find(int id)
    {
        return Find(id);
    }
}