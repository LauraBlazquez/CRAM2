using Npgsql;

namespace CRAM2
{
    public class RescueDAO : IRescueDAO
    {
        private readonly string connectionString;
        public RescueDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<RescueDTO> GetAllRescues()
        {
            List<RescueDTO> rescues = new List<RescueDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM Rescue";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RescueDTO rescue = NpgsqlUtils.GetRescue(reader);
                    rescues.Add(rescue);
                }
            }
            return rescues;
        }
        public RescueDTO SelectById(string id)
        {
            try
            {
                RescueDTO rescue = new RescueDTO();
                using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
                {
                    string query = "SELECT * FROM Rescue WHERE ID = @id";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rescue = NpgsqlUtils.GetRescue(reader);
                    }
                }
                return rescue;
            }
            catch
            {
                return null;
            }
        }
        public void InsertRescue(RescueDTO rescue, bool quiet = false)
        {
            const int Zero = 0, MaxRescueCode = 999;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
                {
                    string query = "INSERT INTO RESCUE (ID, DATE, ANIMAL_ID, GA, LOCATION) VALUES (@id,@date,@animal_id,@ga,@location)";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", rescue.RescueId);
                    command.Parameters.AddWithValue("@date", rescue.RescueDate);
                    command.Parameters.AddWithValue("@animal_id", rescue.RescuedAnimal);
                    command.Parameters.AddWithValue("@ga", rescue.AffectationDegree);
                    command.Parameters.AddWithValue("@location", rescue.Location);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                if (!quiet)
                    MessageBox.Show($"Rescue {rescue.RescueId} inserted.", "Guardat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                rescue.RescueId += HelperClass.RandomValues(Zero, MaxRescueCode).ToString("000");
                InsertRescue(rescue);
            }
        }
    }
}