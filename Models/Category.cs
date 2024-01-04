using Dapper.Contrib.Extensions;

namespace Archivum.Models;

[Table("[Category]")]

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
}