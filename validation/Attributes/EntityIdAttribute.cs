using System.ComponentModel.DataAnnotations;
using validation.Data.Abstractions;

namespace validation.Attributes;

public class EntityIdAttribute : ValidationAttribute
{
    private readonly Type _entityType;

    public EntityIdAttribute(Type entityType)
    {
        _entityType = entityType;
    }
    protected override ValidationResult IsValid(object? value, ValidationContext context)
    {

        if (context.ObjectInstance is not int instance)
        {
            return new ValidationResult($"{nameof(EntityIdAttribute)} was provided with id of incorrect type");
        }
        var httpContextAccessor = context.GetRequiredService<IHttpContextAccessor>()!;

        var repositoryType = typeof(IRepository<>).MakeGenericType(_entityType);

        var foundRepository = httpContextAccessor?.HttpContext?.RequestServices.GetRequiredService(repositoryType) as IRepository;
        
        if (foundRepository is not { } repository)
        {
            return new ValidationResult($"{nameof(EntityIdAttribute)} was provided with id of incorrect type");
        }

        var found = repository.Find(instance);

        return found is not null
            ? ValidationResult.Success
            : new ValidationResult($"Entity of type {_entityType} with id {instance} not found");

    }

}