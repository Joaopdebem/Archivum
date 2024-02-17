using System.Data;
using Archivum.Models;
using Archivum.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Archivum;

public class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;
                                               Database=bdManga;
                                               User ID=sa;
                                               Password=D3vInD0ck3r$@#$;
                                               Trusted_Connection=False; 
                                               TrustServerCertificate=True;";
    public static void Main(string[] args)
    {

        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        ReadUsers(connection);
        ReadRoles(connection);

        connection.Close();
    }
    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var users = repository.Get();

        foreach (var user in users)
            Console.WriteLine(user.Name);

    }

    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new RoleRepository(connection);
        var roles = repository.Get();

        foreach (var role in roles)
            Console.WriteLine(role.Name);

    }


}