using Npgsql;

namespace CRAM2
{
    public class AnimalDAO : IAnimalDAO
    {
        private readonly string connectionString;
        public AnimalDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<AnimalDTO> GetAllAnimals()
        {
            List<AnimalDTO> animals = new List<AnimalDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM Animal";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnimalDTO animal = NpgsqlUtils.GetAnimal(reader);
                    animals.Add(animal);
                }
            }
            return animals;
        }
        public int Count()
        {
            int count = 0;
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT COUNT(*) FROM ANIMAL";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            return count;
        }
        public AnimalDTO SelectById(int id)
        {
            AnimalDTO animal = new AnimalDTO();
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT * FROM ANIMAL WHERE ID = @id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    animal = NpgsqlUtils.GetAnimal(reader);
                }
            }
            return animal;
        }
        public void InsertAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "INSERT INTO ANIMAL (NAME, FAMILY, SPECIE, WEIGHT) VALUES (@name,@family,@specie,@weight) RETURNING ID";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", animal.Name);
                command.Parameters.AddWithValue("@family", animal.Family);
                command.Parameters.AddWithValue("@specie", animal.Specie);
                command.Parameters.AddWithValue("@weight", animal.Weight);
                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Animal {animal.Name} inserted.", "Guardat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "DELETE FROM ANIMAL WHERE ID = @id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", animal.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Animal {animal.Name} deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}