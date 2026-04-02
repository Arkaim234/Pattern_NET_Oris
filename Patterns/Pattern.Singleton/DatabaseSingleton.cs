using System.Text.Json;

namespace Pattern.Singleton
{
    public sealed class DatabaseSingleton
    {
        private static readonly DatabaseSingleton _instance;
        private readonly string _connectionString;

        static DatabaseSingleton()
        {
            string json = File.ReadAllText("appsettings.json");
            var config = JsonSerializer.Deserialize<Config>(json);
            string connectionString = config?.ConnectionString
                ?? throw new Exception("Строка подключения не найдена в appsettings.json");
            _instance = new DatabaseSingleton(connectionString);
        }

        public static DatabaseSingleton Instance => _instance;

        private DatabaseSingleton(string connectionString)
        {
            _connectionString = connectionString;
        }

        private class Config
        {
            public string ConnectionString { get; set; }
        }
    }
}