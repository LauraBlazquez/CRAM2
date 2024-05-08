using System.Text.RegularExpressions;

namespace CRAM2
{
    public partial class AnimalsAdmin : Form
    {
        private AnimalDTO selectedAnimal;
        public AnimalsAdmin()
        {
            InitializeComponent();
            DataGridContent();
        }


        private void DataGridContent()
        {
            AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            List<AnimalDTO> animals = animalDAO.GetAllAnimals();
            dataGridView1.DataSource = animals;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[row];
                AnimalDTO animal = new AnimalDTO
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Name = selectedRow.Cells["Name"].Value.ToString(),
                    Family = selectedRow.Cells["Family"].Value.ToString(),
                    Specie = selectedRow.Cells["Specie"].Value.ToString(),
                    Weight = Convert.ToDecimal(selectedRow.Cells["Weight"].Value),
                };
                selectedAnimal = animal;
                IdInput.Text = animal.Id.ToString();
                AnimalName.Text = animal.Name;
                SuperFamilyComboBox.SelectedItem = animal.Family;
                AnimalSpecie.Text = animal.Specie;
                AnimalWeight.Text = animal.Weight.ToString();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            animalDAO.DeleteAnimal(selectedAnimal);
            CleanInputs();
            dataGridView1.DataSource = null;
            DataGridContent();
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Regex stringsPattern = new Regex(@"^[a-zA-Z\s]+$");
            Regex decimalPattern = new Regex(@"^[0-9]+(?:[\,]\d+)?$");

            if (!stringsPattern.IsMatch(AnimalName.Text))
                MessageBox.Show("No has inserit el nom de l'animal correctament. Només pot contenir lletres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (SuperFamilyComboBox.SelectedItem == null)
                MessageBox.Show("Selecciona una superfamília", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!stringsPattern.IsMatch(AnimalSpecie.Text))
                MessageBox.Show("No has inserit el nom de l'espècie correctament. Només pot contenir lletres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!decimalPattern.IsMatch(AnimalWeight.Text))
                MessageBox.Show("No has inserit el pes correctament. Ex: 12,1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
                AnimalDTO animalDTO = new AnimalDTO
                {
                    Name = AnimalName.Text,
                    Family = SuperFamilyComboBox.SelectedItem.ToString(),
                    Specie = AnimalSpecie.Text,
                    Weight = Convert.ToDecimal(AnimalWeight.Text),
                };
                animalDAO.InsertAnimal(animalDTO);
            }
            CleanInputs();
            dataGridView1.DataSource = null;
            DataGridContent();

        }
        private void CleanInputs()
        {
            AnimalName.Text = "";
            SuperFamilyComboBox.SelectedItem = null;
            AnimalSpecie.Text = "";
            AnimalWeight.Text = "";
        }
        private void Return_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }


    }
}
