using Dapper.Contrib.Extensions;

namespace Archivum.Models;

[Table("[User]")]

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public string? Image { get; set; }
    public string? Slug { get; set; }
}