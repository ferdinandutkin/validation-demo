using System.ComponentModel.DataAnnotations;
using validation.Data.Abstractions;
using validation.Data.Models;

namespace validation.Attributes;


public class DuckIdAttribute : EntityIdAttribute
{
    public DuckIdAttribute() : base(typeof(Duck))
    {
    }
}