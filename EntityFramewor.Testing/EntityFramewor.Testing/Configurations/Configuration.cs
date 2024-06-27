using EntityFramewor.Testing.Models;
using System.Text;
using System.Text.Json;

namespace EntityFramewor.Testing.Configurations
{
    public static class Configuration
    {
        private static string testDataFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\TestData\user.json");
        private static string dbConfigFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\config.json");

        public static User TestUser => JsonSerializer.Deserialize<User>(ReadConfigurationFile(testDataFileName))!;

        public static string DatabaseConnectionString => JsonSerializer.Deserialize<DatabaseConfiguration>(ReadConfigurationFile(dbConfigFileName))!.DatabaseConnectionString;

        private static string ReadConfigurationFile(string filePath) => File.ReadAllText(filePath, Encoding.Default);
    }
}
