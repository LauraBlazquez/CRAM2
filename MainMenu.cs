namespace CRAM2
{
    public partial class MainMenu : Form
    {
        private UserDTO user;
        public MainMenu(UserDTO user)
        {
            this.user = user;
            InitializeComponent();
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AnimalsAdmin animalsAdmin = new AnimalsAdmin();
            this.Hide();
            animalsAdmin.ShowDialog();
            this.Close();
        }

        private void ViewRescues_Click(object sender, EventArgs e)
        {
            RescueHistory rescueHistory = new RescueHistory();
            this.Hide();
            rescueHistory.ShowDialog();
            this.Close();
        }

        private void NewRescue_Click(object sender, EventArgs e)
        {
            MiniGame miniGame = new MiniGame(user);
            this.Hide();
            miniGame.ShowDialog();
            this.Close();
        }
    }
}
