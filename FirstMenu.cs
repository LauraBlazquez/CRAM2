namespace CRAM2
{
    public partial class FirstMenu : Form
    {
        public FirstMenu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            UserSelection userSelection = new UserSelection();
            this.Hide();
            userSelection.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
