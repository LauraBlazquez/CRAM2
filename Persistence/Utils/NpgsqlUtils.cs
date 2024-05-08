using Microsoft.Extensions.Configuration;
using Npgsql;

namespace CRAM2
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            return config.GetConnectionString("MyPostgresConn");
        }
        public static AnimalDTO GetAnimal(NpgsqlDataReader reader)
        {
            AnimalDTO a = new AnimalDTO
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Family = reader.GetString(2),
                Specie = reader.GetString(3),
                Weight = reader.GetDecimal(4),
            };
            return a;
        }
        public static RescueDTO GetRescue(NpgsqlDataReader reader)
        {
            RescueDTO r = new RescueDTO
            {
                RescueId = reader.GetString(0),
                RescueDate = reader.GetString(1),
                RescuedAnimal = reader.GetInt32(2),
                AffectationDegree = reader.GetInt32(3),
                Location = reader.GetString(4),
            };
            return r;
        }
    }
}