using Archivum.Models;
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
        ReadUsers();
    }
    public static void ReadUsers()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var users = connection.GetAll<User>();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }

}