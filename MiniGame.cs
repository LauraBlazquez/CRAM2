using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace CRAM2
{
    public partial class MiniGame : Form
    {
        private RescueDTO rescue = new RescueDTO();
        private AnimalDTO animal;
        private UserDTO user;
        public MiniGame(UserDTO user)
        {
            InitializeComponent();

            const int Zero = 0, MaxRescueCode = 999, MaxAffection = 99;
            string[] cities = { "Cadaquès", "Gavà", "Mataró" };
            AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());

            rescue.RescueId += HelperClass.RandomValues(Zero, MaxRescueCode).ToString("000");
            rescue.RescuedAnimal = HelperClass.RandomValues(Zero, animalDAO.Count()-1);
            rescue.AffectationDegree = HelperClass.RandomValues(Zero, MaxAffection);
            rescue.Location = HelperClass.RandomStrings(cities);
            MiniGame_Load();
            this.user = user ?? throw new ArgumentNullException(nameof(user));
        }

        private void MiniGame_Load()
        {
            AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            this.animal = animalDAO.SelectById(rescue.RescuedAnimal);

            RescueNum.Text = rescue.RescueId;
            RescueDate.Text = rescue.RescueDate.ToString();
            SuperFamily.Text = animal.Family;
            Affectation.Text = rescue.AffectationDegree.ToString();
            Location.Text = rescue.Location;

            NameInput.Text = animal.Name;
            SpecieInput.Text = animal.Specie;
            WeightInput.Text = animal.Weight.ToString();

            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            rescueDAO.InsertRescue(rescue,true);
        }
        private void Locally_Click(object sender, EventArgs e)
        {
            CalculateGA(true);
        }
        private void CRAM_Click(object sender, EventArgs e)
        {
            CalculateGA(false);
        }

        private void CalculateGA (bool option)
        {
            const int AppropriateMaxGA = 30, Victory = 50, Defeat = 20;
            double result = 0;
            switch (animal.Family)
            {
                case "Tortuga Marina":
                    result = HelperClass.CalculateTurtleGA(rescue);
                    break;
                case "Au Marina":
                    result = HelperClass.CalculateBirdGA(rescue, option);
                    break;
                case "Cetaci":
                    result = HelperClass.CalculateCetaceanGA(rescue, option);
                    break;
            }
            MessageBox.Show($"El grau d'afectació de l'animal s'ha reduït al {result} %");

            if (result <= AppropriateMaxGA)
            { 
                this.user.Experience += Victory;
                MessageBox.Show("L'animal està suficientment recuperat per tornar al seu habitat natural." +
                                    "\nEnhorabona! Has guanyat 50 punts d'experiència." +
                                    "\nPunts finals:" + this.user.Experience);
            }
            else
            {
                this.user.Experience -= Defeat;
                MessageBox.Show("L'animal no està suficientment recuperat per tornar al seu habitat natural." +
                                               "\nCal traslladar-lo al centre de recuperació." +
                                               "\nHas perdut 20 punts d'experiència :(" +
                                               "\nPunts finals:" + this.user.Experience);
            }
            SaveUserLINQ();
        }
                    
        public void SaveUserLINQ()
        {
            const string Path = "../../../files/users.xml";
            if (!File.Exists(Path))
            {
                CreateXmlLINQ();
            }
            XDocument doc = XDocument.Load(Path);
            XElement root = doc.Element("Users");
            root.Add(new XElement("User",
                         new XElement("Name", user.Name),
                         new XElement("Rol", user.Rol),
                         new XElement("Experience", user.Experience)
                        )
                     );
            doc.Save(Path);
            Return();
        }
        public void CreateXmlLINQ()
        {
            const string Path = "../../../files/users.xml";
            XDocument doc = new XDocument(
                new XElement("Users")
            );
            doc.Save(Path);
        }
        public void Return()
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(user);
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
