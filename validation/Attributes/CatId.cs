using System.ComponentModel.DataAnnotations;
using validation.Data.Abstractions;
using validation.Data.Models;

namespace validation.Attributes;


public class CatIdAttribute : EntityIdAttribute
{
    public CatIdAttribute() : base(typeof(Cat))
    {
    }
}