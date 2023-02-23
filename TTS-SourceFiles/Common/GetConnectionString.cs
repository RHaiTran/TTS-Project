using System;
using System.Data.SqlClient;

namespace TTS_SourceFiles.Common
{
    public static class GetConnectionString
    {
        public static string ConnectionStrings {get; }
        static GetConnectionString()
        {
            var configurationBuilder = new ConfigurationBuilder();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, optional: false);

            var configuration = configurationBuilder.Build();
            ConnectionStrings = configuration.GetSection("ConnectionStrings").GetValue<string>("DBName");
        }
    }
}