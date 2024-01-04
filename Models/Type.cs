using Dapper.Contrib.Extensions;

namespace Archivum.Models;

[Table("[Type]")]

public class Type
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
}