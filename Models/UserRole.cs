using Dapper.Contrib.Extensions;

namespace Archivum.Models;

[Table("[UserRole]")]

public class UserRole
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
}