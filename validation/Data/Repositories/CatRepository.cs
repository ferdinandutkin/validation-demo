using validation.Data.Abstractions;
using validation.Data.Models;

namespace validation.Data.Repositories;

public class CatRepository : IRepository<Cat>
{
    public Cat? Find(int id)
    {
        if (id < 3)
        {
            return new Cat() {Id = id};
        }

        return null;
    }

    object? IRepository.Find(int id)
    {
        return Find(id);
    }
}