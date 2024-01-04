using System.Data;
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
        //ReadUsers();
        //ReadUser();
        //CreateUser();
        //UpdateUser();
        DeleteUser();
    }
    public static void ReadUsers()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var users = connection.GetAll<User>();

            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id};\nName: {user.Name};\nEmail = {user.Email};\nImage = {user.Image};\nSlug = {user.Slug}\n");
            }
        }
    }

    public static void ReadUser()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var user = connection.Get<User>(1);

            Console.WriteLine(user.Name);
        }
    }

    public static void CreateUser()
    {

        var user = new User()
        {
            Name = "Teste",
            Email = "teste@gmail.com",
            PasswordHash = "teste",
            Image = "https://mpng",
            Slug = "testando-teste"
        };

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Insert<User>(user);
            Console.WriteLine("Registro realizado com sucesso.");
        }


    }

    public static void UpdateUser()
    {

        var user = new User()
        {
            Id = 2,
            Name = "João Pedro",
            Email = "joao@gmail.com",
            PasswordHash = "698dc19d489c4e4db73e28a713ea4507b",
            Image = "https://i.imgur.com/TGSACle.png",
            Slug = "joao-pedro"
        };

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Update<User>(user);
            Console.WriteLine("Registro atualizado com sucesso.");
        }

    }

    public static void DeleteUser()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var user = connection.Get<User>(3);
            connection.Delete<User>(user);
            Console.WriteLine("Exclusão realizada com sucesso.");
        }

    }


}